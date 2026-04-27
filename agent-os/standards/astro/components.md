# Standard: Astro Components

## Location
`astro/src/components/` and `astro/src/layouts/`

## Conventions

- One component per file, PascalCase filename (e.g. `Nav.astro`, `PricesTable.astro`)
- Props declared in frontmatter with a TypeScript `interface Props`
- Scoped `<style>` blocks preferred; global styles only in `global.css`
- Inline `<script>` blocks for component interactivity (vanilla JS, no framework)
- No React, no Tailwind — plain HTML/CSS only

## Existing Components

| Component | Purpose |
|---|---|
| `Layout.astro` | Page shell — head, GTM, Nav, ContactSidebar, footer |
| `Nav.astro` | Top nav with dropdown (desktop) and hamburger (mobile) |
| `ContactSidebar.astro` | Contact form sidebar using Web3Forms API |
| `PricesTable.astro` | Pricing table — used on home + `/services/prices/` |

## Layout Usage

Every page wraps content in `<Layout>` with title, description, and keywords:

```astro
---
import Layout from '../../layouts/Layout.astro';
---
<Layout
  title="Page Title"
  description="Meta description for SEO"
  keywords="comma, separated, keywords"
>
  <!-- page content -->
</Layout>
```
