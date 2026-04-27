# TaxDoctor — Agent Context

## What this project is
Website for a South African tax and accounting practice (Justin's dad's business).
Live site: http://www.mytaxdoctor.co.za/
Business address: 73 Mackay Avenue, Blairgowrie, Randburg, 2194
Contact: Tel 011 787-7279 · Cell 073 874-6774 · taxdoctorsa@gmail.com

## Migration in progress
Converting from **ASP.NET MVC 3 (C#)** → **Astro 6, fully static, Cloudflare Pages**.

- Legacy MVC source: `src/TaxDoctor.Web/` (no longer used)
- New Astro site: `astro/` subfolder, on master branch
- Deployment: Cloudflare Pages (live at taxdoctor.pages.dev, DNS pending)
- Status: Deployed to Pages, awaiting DNS nameserver change at registeredomain.co.za

## Astro project (`astro/`)

### Stack
- Astro 6, `output: 'static'`
- No framework (no React, no Tailwind) — plain HTML/CSS in `.astro` files
- Global styles: `src/styles/global.css` (ported from `Content/NewLook.css`)
- Contact form: Web3Forms API (free, 250/month) — key in `.env` as `PUBLIC_WEB3FORMS_KEY`
- Redirects: `public/_redirects` (old MVC PascalCase routes → new kebab-case)

### Structure
```
astro/
  astro.config.mjs       output: static, site: https://www.mytaxdoctor.co.za
  wrangler.toml          Cloudflare Pages deploy config (no D1, no Workers)
  .env.example           PUBLIC_WEB3FORMS_KEY=...
  public/
    _redirects           301s from all old /Services/X and /Training/X routes
    images/              All site images (copied from Content/images/)
    favicon*, site.webmanifest.json
  src/
    layouts/Layout.astro     GTM-M682998, nav, contact sidebar, footer
    components/
      Nav.astro              Dropdown nav + mobile hamburger
      ContactSidebar.astro   Web3Forms contact form with honeypot spam protection
      PricesTable.astro      Reusable prices table (home + /services/prices/)
    styles/global.css
    pages/
      index.astro
      about.astro
      services/            accounting, bank-loan-applications, bookkeeping,
                           business-plans, cash-flow, company-formations,
                           financial-statements, payroll, payroll-paye,
                           tax-services, prices, index
      training/            index, accounting, excel, packages, pastel, quickbooks
```

### Pages: 20 total
All pages use `<Layout title="..." description="..." keywords="...">`.
Prices table is a shared component used in `index.astro` and `services/prices.astro`.

## To run locally
```bash
cd astro
npm cache clean --force   # if "Invalid Version" error
npm install
npm run dev               # → http://localhost:4321
```

## To deploy
```bash
# 1. Get a free Web3Forms key at https://web3forms.com
# 2. Add to astro/.env: PUBLIC_WEB3FORMS_KEY=your_key
# 3. Connect repo to Cloudflare Pages:
#    - Build command: npm run build
#    - Output dir: dist
#    - Root dir: astro
#    - Env var: PUBLIC_WEB3FORMS_KEY=your_key
```

## DNS & Domain Setup
- **Domain registrar:** registerdomain.co.za
- **Hosting:** Cloudflare Pages (taxdoctor.pages.dev preview, mytaxdoctor.co.za live)
- **DNS nameservers:** Update at registerdomain.co.za to Cloudflare's nameservers when adding custom domain to Pages
- **Email:** MX records (m07.internetmailserver.net) stay on current provider, kept after nameserver change
- **Old hosting:** WinHost (cancel hosting, keep domain at registeredomain.co.za)

## Git
- Main branch: `master` (Astro site + CI/CD, deployed to Cloudflare Pages)
- GitHub: jagberg/TaxDoctor (migrated from GitLab)
- CI/CD: Native Cloudflare Pages GitHub integration (auto-deploy on push to master)

## Reference project
`C:\Code\Bilder\bilder-site` — another Astro 6 + Cloudflare site (more complex:
has D1 database, Keystatic CMS, React, Pagefind). Good reference for Cloudflare
adapter config and Nav/Layout patterns. TaxDoctor is intentionally simpler.

## Key decisions made
- `output: 'static'` (not hybrid/server) — no server needed, cheaper, simpler
- No Cloudflare adapter needed for static-only output
- Web3Forms over Nodemailer — avoids needing SSR just for one contact form
- No Tailwind — site is small enough that plain CSS is fine; preserves original look
- Wrangler in devDeps for CLI deploys but not required (can deploy via Cloudflare dashboard)
