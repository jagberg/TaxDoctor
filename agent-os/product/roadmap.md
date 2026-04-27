# Product Roadmap

## Phase 1: MVP — Astro Migration (in progress)

- [x] Scaffold Astro 6 project in `astro/` subfolder
- [x] Port Layout, Nav, ContactSidebar, PricesTable components
- [x] Port all 20 pages (Home, About, 12 Services, 5 Training + index pages)
- [x] Copy all images and favicons to `public/`
- [x] Add `_redirects` for all old ASP.NET MVC routes
- [x] Web3Forms contact form with honeypot spam protection
- [x] GTM-M682998 analytics tag in Layout
- [ ] `npm install` and local dev verify (`npm run dev`)
- [ ] Get Web3Forms access key and test form submission
- [ ] Commit to `astro-preview` branch (blocked by git lock — close VS Code/GitHub Desktop first)
- [ ] Connect repo to Cloudflare Pages and do first deploy
- [ ] Update DNS (`mytaxdoctor.co.za`) to point to Cloudflare Pages

## Phase 2: Post-Launch Polish

- [ ] Review and update prices (currently showing old prices in rands)
- [ ] Add proper page for Business Plans and Cash Flow (currently have placeholder content)
- [ ] Mobile responsiveness pass — ensure all pages look good on phones
- [ ] Google Search Console — verify no crawl errors post-migration
- [ ] Consider adding a sitemap.xml (Astro has a built-in integration for this)

## Phase 3: Nice to Have

- [ ] Refresh copy on key service pages
- [ ] Add a blog or news section for SARS deadlines / tax tips (good for SEO)
- [ ] WhatsApp contact button (very common for SA businesses)
