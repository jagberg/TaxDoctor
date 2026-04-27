# References for Astro Migration

## Legacy Source

### ASP.NET MVC 3 site
- **Location:** `src/TaxDoctor.Web/`
- **Key files:**
  - `Views/Shared/_Layout.cshtml` — original layout (nav, contact sidebar, footer)
  - `Views/Home/Index.cshtml` — home page content
  - `Views/Shared/Prices.cshtml` — pricing table (now `PricesTable.astro`)
  - `Content/NewLook.css` — all styles (now `src/styles/global.css`)
  - `Controllers/ContactController.cs` — contact form handler (replaced by Web3Forms)

## Reference Implementation

### bilder-site
- **Location:** `C:\Code\Bilder\bilder-site`
- **Relevance:** Production Astro 6 + Cloudflare Pages site owned by the same developer
- **Key patterns borrowed:**
  - `astro.config.mjs` structure (simplified — removed cloudflare adapter, react, tailwind, keystatic)
  - `wrangler.toml` format (simplified — no D1 database bindings)
  - `Nav.astro` — dropdown + mobile overlay pattern (adapted for TaxDoctor's menu structure)
  - `Layout.astro` — overall shell structure (adapted with TaxDoctor branding and GTM)
