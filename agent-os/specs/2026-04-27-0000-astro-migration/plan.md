# Astro Migration — Plan

## Goal
Migrate mytaxdoctor.co.za from ASP.NET MVC 3 to Astro 6 + Cloudflare Pages.
Fully static output. Free hosting with South African CDN PoPs.

## Status: In Progress

### Completed
- [x] Astro project scaffolded in `astro/` subfolder
- [x] Layout, Nav, ContactSidebar, PricesTable components built
- [x] All 20 pages ported from .cshtml → .astro
- [x] Images and favicons copied to `public/`
- [x] `_redirects` file for all old MVC routes
- [x] `wrangler.toml` for Cloudflare Pages deployment
- [x] `agent-os/` bootstrapped with product docs and standards

### Remaining Tasks
- [ ] Fix `npm install` error (try `npm cache clean --force` first) and run `npm run dev`
- [ ] Get Web3Forms key (free at web3forms.com) and test contact form
- [ ] Commit `astro/` to `astro-preview` branch (close VS Code/GitHub Desktop to free git lock)
- [ ] Push `astro-preview` to origin
- [ ] Connect repo to Cloudflare Pages dashboard
- [ ] Set `PUBLIC_WEB3FORMS_KEY` env var in Cloudflare Pages
- [ ] Verify build succeeds (`npm run build`)
- [ ] Update DNS for `mytaxdoctor.co.za` to point to Cloudflare Pages
- [ ] Smoke test all 20 pages and contact form on live URL
- [ ] Check Google Search Console for crawl errors

## Key Decisions

See `shape.md` for full reasoning.
