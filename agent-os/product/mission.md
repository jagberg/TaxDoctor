# Product Mission

## Problem

mytaxdoctor.co.za is a South African tax and accounting practice website currently running on legacy ASP.NET MVC 3 (C#, .NET Framework). It's slow to update, requires a Windows server to host, and the stack is end-of-life. Visitors in South Africa experience poor latency because the site is hosted far from them.

## Target Users

- **South African individuals** looking for affordable personal tax return services (IT12, IRP5, IRP6)
- **Small South African businesses** needing bookkeeping, payroll, company formations, and financial statements
- **Businesses seeking training** in accounting packages (Quickbooks, Pastel Payroll, Excel)

The business is a small practice in Blairgowrie, Randburg, Johannesburg run by Justin's dad.

## Solution

Migrate the site to **Astro 6 + Cloudflare Pages** — a fully static site with:
- Zero ongoing hosting cost (Cloudflare free tier)
- Content served from Cloudflare's Johannesburg and Cape Town PoPs (low SA latency)
- Trivially easy to update (edit `.astro` files, push to Git, auto-deploy)
- Contact form via Web3Forms (free, no server needed)
- Preserves all existing SEO (301 redirects from old MVC URLs)
