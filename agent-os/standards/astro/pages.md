# Standard: Astro Pages

## Location
`astro/src/pages/`

## URL Structure

| Directory | URL prefix |
|---|---|
| `pages/index.astro` | `/` |
| `pages/about.astro` | `/about/` |
| `pages/services/*.astro` | `/services/*/` |
| `pages/training/*.astro` | `/training/*/` |

`trailingSlash: 'always'` is set in `astro.config.mjs` — all URLs end with `/`.

## Redirects

Old ASP.NET MVC PascalCase URLs (e.g. `/Services/TaxServices`) redirect to new
kebab-case URLs (e.g. `/services/tax-services/`) via `astro/public/_redirects`.

When adding a new page that has a legacy URL equivalent, add a redirect entry.

## SEO

Every page should set meaningful `title`, `description`, and `keywords` on `<Layout>`.
Keywords should include South African context (e.g. "johannesburg", "sars", "south africa").

## Images

All images live in `astro/public/images/` and are referenced as `/images/...`.
Sub-folders mirror the original: `Home/`, `Services/`, `Training/`.
