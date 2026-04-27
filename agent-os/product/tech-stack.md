# Tech Stack

## Frontend

- **Astro 6** — static site generator, `output: 'static'`
- **Plain HTML/CSS** in `.astro` files — no React, no Vue, no Tailwind
- **Global styles** — `astro/src/styles/global.css` (ported from legacy `Content/NewLook.css`)
- **JavaScript** — vanilla, inline in `<script>` blocks inside `.astro` files

## Backend

- **None** — fully static output, no server-side rendering
- Contact form handled client-side via Web3Forms API fetch

## Hosting & Infrastructure

- **Cloudflare Pages** — free tier, static asset serving
  - Build command: `npm run build`
  - Output directory: `dist`
  - Root directory: `astro`
  - Johannesburg + Cape Town PoPs serve South African visitors
- **Wrangler** — in devDependencies for optional CLI deploys (`wrangler pages deploy dist`)

## Third-Party Services

- **Web3Forms** — contact form email delivery (free, 250 submissions/month)
  - Access key stored in `astro/.env` as `PUBLIC_WEB3FORMS_KEY`
  - Also set as environment variable in Cloudflare Pages dashboard
- **Google Tag Manager** — GTM-M682998 (already in use, carried over from legacy site)

## Domain

- `mytaxdoctor.co.za` — `.co.za` South African domain
- DNS: CNAME `www` → Cloudflare Pages project URL
- SSL: Provided free by Cloudflare Pages

## Legacy (being replaced)

- **ASP.NET MVC 3** (C#, .NET Framework) — source in `src/TaxDoctor.Web/`
- Deployed via FTP to Windows hosting
- Contact form used Gmail SMTP via `System.Net.Mail.SmtpClient`

## CI/CD Pipeline

- **GitHub Actions** — Native Cloudflare Pages integration (GitHub → automatic build & deploy)
- **Repository** — Hosted on GitHub (migrated from GitLab)
- **Deployment trigger** — Push to `master` branch auto-triggers build & deploy
- **Build command** — `npm run build` (runs from `astro/` directory)
- **Build output** — Static files written to `astro/dist/`
- **Environment variables** — Set in Cloudflare Pages dashboard:
  - `PUBLIC_WEB3FORMS_KEY` (Web3Forms contact form key)

## Reference Project

- `C:\Code\Bilder\bilder-site` — a more complex Astro 6 + Cloudflare site
  - Uses D1 database, Keystatic CMS, React, Pagefind, Tailwind
  - Good reference for Cloudflare adapter patterns and Nav/Layout structure
