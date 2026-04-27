# Astro Migration — Shaping Notes

## Scope

Full migration of mytaxdoctor.co.za (ASP.NET MVC 3, C#) to Astro 6 static site
deployed on Cloudflare Pages. 20 pages, one contact form, no database.

## Decisions

- **`output: 'static'`** — no SSR needed; avoids needing Cloudflare Workers or adapter
- **No Cloudflare adapter** — static files served directly from CDN, simpler and cheaper
- **Web3Forms for contact form** — free (250/month), client-side only, preserves honeypot anti-spam
- **No Tailwind** — site is small, original CSS preserved from `NewLook.css`, no build complexity needed
- **No React** — no dynamic UI; plain `.astro` components with vanilla JS scripts are sufficient
- **Astro in `astro/` subfolder** — legacy `src/TaxDoctor.Web/` preserved on `master` branch
- **`astro-preview` branch** — keeps legacy site live on `master` until migration is verified
- **Cloudflare Pages** — Johannesburg PoP gives good SA latency; free tier is sufficient forever
- **Kebab-case URLs** — cleaner than old PascalCase MVC routes; 301 redirects preserve SEO

## Context

- **Visuals:** Live site at http://www.mytaxdoctor.co.za/ — same visual design preserved
- **References:** `C:\Code\Bilder\bilder-site` — Astro 6 + Cloudflare (more complex) used as reference for config patterns
- **Product alignment:** Cost is R0 ongoing (excluding domain ~R150/year)

## Standards Applied

- `astro/components` — component structure and naming
- `astro/pages` — URL conventions and SEO meta
- `cloudflare/deployment` — build settings and environment variables
- `css/conventions` — layout IDs, class names, breakpoints
