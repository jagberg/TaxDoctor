# TaxDoctor → Astro + Cloudflare Pages Migration Plan

## What we're starting from

The current site is an **ASP.NET MVC 3 application** (C#) deployed via FTP to mytaxdoctor.co.za. It's essentially a static brochure site — no database, no CMS — with one dynamic piece: a contact form that sends email via Gmail SMTP.

This maps perfectly onto **Astro (fully static output) + Cloudflare Pages**, which is free, fast, and has a Point of Presence in **Johannesburg** — meaning South African visitors get content served from inside the country.

---

## Why Cloudflare Pages for a South African site

Cloudflare has PoPs in **Johannesburg (JNB)** and **Cape Town (CPT)**. With a static Astro build, all HTML, CSS, and images are cached at whichever PoP is closest to the visitor — no round trip to a European or US server. This is the best free option for low-latency serving in South Africa.

**Cost: R0.** Cloudflare Pages free tier includes:
- Unlimited sites and bandwidth
- 500 builds/month
- Custom domain (bring your own `mytaxdoctor.co.za`)
- Free SSL certificate

---

## What to borrow directly from `C:\Code\bilder\bilder-site`

Bilder already has the exact Cloudflare + Astro stack working in production. These files transfer across with minimal changes:

| Bilder file | Use in TaxDoctor | Changes needed |
|---|---|---|
| `astro.config.mjs` | Base config | Remove keystatic, pagefind, react; change `output` to `'static'`; update `site` URL |
| `wrangler.toml` | Cloudflare Pages deploy config | Change `name`, remove D1 database bindings |
| `src/components/Nav.astro` | Full nav with dropdown + mobile overlay | Update nav links/groups for TaxDoctor pages |
| `src/layouts/Layout.astro` | Page shell | Swap branding, fonts, colours; replace GA4 with existing GTM-M682998; remove search/sidebar widget |
| `src/styles/global.css` | Base styles | Keep Tailwind setup; replace colour palette with TaxDoctor's existing scheme from `NewLook.css` |
| `package.json` | Dependencies | Remove keystatic, pagefind, react; keep cloudflare adapter, tailwind |
| `.npmrc` | npm config | Copy as-is |
| `tsconfig.json` | TypeScript config | Copy as-is |

---

## Key simplification vs bilder

Bilder uses `output: 'server'` (SSR) because it has API routes talking to a Cloudflare D1 database (for likes). TaxDoctor needs **none of that**. The config becomes much simpler:

```js
// astro.config.mjs
import { defineConfig } from 'astro/config';
import cloudflare from '@astrojs/cloudflare';
import tailwindcss from '@tailwindcss/vite';

export default defineConfig({
  output: 'static',          // ← fully static, no Workers needed
  site: 'https://www.mytaxdoctor.co.za',
  vite: {
    plugins: [tailwindcss()],
  },
});
```

With `output: 'static'`, Astro builds to plain HTML/CSS/JS files. Cloudflare Pages serves them directly from its CDN — no compute cost, no cold starts, effectively free forever.

---

## The contact form — keeping it free and static

The current form posts to an ASP.NET controller which sends email via Gmail SMTP. On a static site there's no server to do this. The solution is **Web3Forms** — a free form-to-email service:

- Free tier: 250 submissions/month (more than enough for a tax practice)
- No backend code needed — just a POST from JavaScript
- Delivers to any email address (keep sending to `jagberg@gmail.com` as now)
- Honeypot anti-spam field supported (same pattern as the existing `SpamText` field)
- No Cloudflare Worker or SSR needed

Setup is: create a free account at web3forms.com, get an access key, POST to `https://api.web3forms.com/submit`. The form component becomes a pure `.astro` file with a `<script>` block — no server involved.

Alternative: **Formspree** (free tier 50/month) or **Netlify Forms** (doesn't apply here). Web3Forms has the most generous free limit.

---

## Site structure

### Pages (20 total)

| Current MVC route | New Astro file | New URL |
|---|---|---|
| `/` | `src/pages/index.astro` | `/` |
| `/Home/About` | `src/pages/about.astro` | `/about/` |
| `/Services/OurServices` | `src/pages/services/index.astro` | `/services/` |
| `/Services/Accounting` | `src/pages/services/accounting.astro` | `/services/accounting/` |
| `/Services/BankLoanApplications` | `src/pages/services/bank-loan-applications.astro` | `/services/bank-loan-applications/` |
| `/Services/Bookkeeping` | `src/pages/services/bookkeeping.astro` | `/services/bookkeeping/` |
| `/Services/BusinessPlans` | `src/pages/services/business-plans.astro` | `/services/business-plans/` |
| `/Services/CashFlow` | `src/pages/services/cash-flow.astro` | `/services/cash-flow/` |
| `/Services/CompanyFormations` | `src/pages/services/company-formations.astro` | `/services/company-formations/` |
| `/Services/FinancialStatements` | `src/pages/services/financial-statements.astro` | `/services/financial-statements/` |
| `/Services/Payroll` | `src/pages/services/payroll.astro` | `/services/payroll/` |
| `/Services/PayrollPAYE` | `src/pages/services/payroll-paye.astro` | `/services/payroll-paye/` |
| `/Services/Prices` | `src/pages/services/prices.astro` | `/services/prices/` |
| `/Services/TaxServices` | `src/pages/services/tax-services.astro` | `/services/tax-services/` |
| `/Training/Training` | `src/pages/training/index.astro` | `/training/` |
| `/Training/Accounting` | `src/pages/training/accounting.astro` | `/training/accounting/` |
| `/Training/Excel` | `src/pages/training/excel.astro` | `/training/excel/` |
| `/Training/Packages` | `src/pages/training/packages.astro` | `/training/packages/` |
| `/Training/Pastel` | `src/pages/training/pastel.astro` | `/training/pastel/` |
| `/Training/QuickBooks` | `src/pages/training/quickbooks.astro` | `/training/quickbooks/` |

### Shared components

- `src/layouts/Layout.astro` — page shell (head, GTM, nav, contact sidebar, footer)
- `src/components/Nav.astro` — dropdown nav + mobile overlay (ported from bilder)
- `src/components/ContactSidebar.astro` — contact form using Web3Forms
- `src/components/PricesTable.astro` — reused on home + prices page

### Assets (direct copy, no changes)

```
src/assets/   ← Content/images/ (all .jpg, .png, .svg)
public/       ← Content/favicons/ (favicon files)
src/styles/   ← Content/NewLook.css (ported to global.css)
```

---

## URL redirects (SEO preservation)

Add a `public/_redirects` file (Cloudflare Pages format):

```
/Services/Accounting          /services/accounting/          301
/Services/BankLoanApplications /services/bank-loan-applications/ 301
/Services/Bookkeeping         /services/bookkeeping/         301
/Services/BusinessPlans       /services/business-plans/      301
/Services/CashFlow            /services/cash-flow/           301
/Services/CompanyFormations   /services/company-formations/  301
/Services/FinancialStatements /services/financial-statements/ 301
/Services/OurServices         /services/                     301
/Services/Payroll             /services/payroll/             301
/Services/PayrollPAYE         /services/payroll-paye/        301
/Services/Prices              /services/prices/              301
/Services/TaxServices         /services/tax-services/        301
/Training/Training            /training/                     301
/Training/Accounting          /training/accounting/          301
/Training/Excel               /training/excel/               301
/Training/Packages            /training/packages/            301
/Training/Pastel              /training/pastel/              301
/Training/QuickBooks          /training/quickbooks/          301
/Home/About                   /about/                        301
```

---

## Wrangler config (simplified from bilder)

```toml
# wrangler.toml
name = "taxdoctor-site"
compatibility_date = "2026-04-26"

[assets]
directory = "dist"
```

No D1 bindings, no Workers — just static asset serving.

---

## Step-by-step execution order

1. **Scaffold Astro project** inside `C:\Code\TaxDoctor` (or a sibling folder like `C:\Code\TaxDoctor-Astro`)
2. **Copy config files from bilder**: `astro.config.mjs`, `wrangler.toml`, `tsconfig.json`, `.npmrc`, `package.json` — then strip out bilder-specific dependencies
3. **Install dependencies**: `npm install`
4. **Port `Layout.astro`** from bilder — update branding, colours, GTM tag (GTM-M682998), remove search sidebar
5. **Port `Nav.astro`** from bilder — update nav groups/links to match TaxDoctor's menu structure
6. **Copy assets** — images, favicons, CSS into `src/assets/` and `public/`
7. **Port `NewLook.css`** into `src/styles/global.css` alongside Tailwind
8. **Build `PricesTable.astro`** component (from `Views/Shared/Prices.cshtml`)
9. **Port all 20 pages** — Home and About first (simplest), then Services, then Training. Each .cshtml maps 1:1 to a .astro file; content is copy-paste with Razor syntax removed
10. **Build `ContactSidebar.astro`** with Web3Forms — sign up, get access key, store in `.env`
11. **Add `public/_redirects`** for old MVC-style URLs
12. **Test locally**: `npm run dev` — check all pages, form submission, nav dropdowns
13. **Deploy to Cloudflare Pages**:
    - Push to GitHub
    - Connect repo to Cloudflare Pages (free account)
    - Build command: `npm run build`, output: `dist`
    - Set `WEB3FORMS_KEY` environment variable in Cloudflare Pages dashboard
14. **Point DNS**: update `mytaxdoctor.co.za` DNS to Cloudflare Pages (add CNAME in current DNS provider, or transfer domain to Cloudflare for free DNS management)
15. **Verify**: GTM firing, redirects working, contact form delivering to inbox, Google Search Console showing no crawl errors

---

## DNS and domain notes

The current domain is `mytaxdoctor.co.za` (a `.co.za` domain). To point it to Cloudflare Pages:
- Add a `CNAME` record pointing `www` to your Cloudflare Pages project URL (e.g. `taxdoctor-site.pages.dev`)
- For the apex/root domain (`mytaxdoctor.co.za` without www), use Cloudflare's "CNAME flattening" — this requires the domain's nameservers to be at Cloudflare. If you don't want to move nameservers, you can redirect the apex to `www` at your current registrar.
- Cloudflare provides the SSL certificate automatically at no cost.

---

## Total ongoing cost: R0

| Service | Free tier |
|---|---|
| Cloudflare Pages hosting | Unlimited bandwidth, 500 builds/month |
| Cloudflare SSL | Included |
| Web3Forms contact form | 250 submissions/month |
| Domain renewal | ~R150/year at current registrar (unchanged) |
