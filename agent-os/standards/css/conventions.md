# Standard: CSS Conventions

## Location
`astro/src/styles/global.css` — single global stylesheet, no CSS modules, no Tailwind.

## Origin
Ported from legacy `src/TaxDoctor.Web/Content/NewLook.css`. Preserves the original site's visual design.

## Key layout IDs

| Selector | Purpose |
|---|---|
| `#header` / `#header-inner` | Blue header bar with logo |
| `#nav` / `#nav-inner` | Horizontal nav with dropdowns |
| `#article` | Two-column flex container (sidebar + main) |
| `#contact-sidebar` | Right-side contact form (180px wide, moves to top on mobile) |
| `#main-content` | Page content area |
| `#footer` / `#footer-inner` | Footer with service links |

## Key classes

| Class | Purpose |
|---|---|
| `.section` | White rounded-border content box |
| `.sections` | CSS grid for home page multi-column layout |
| `.contactus` | Contact form box styling |
| `.image-section` | Float-right images within `.section` |
| `.image-package` | Float-left images (training package logos) |
| `ul.alt` | Styled list (square bullets, indented) |

## Responsive breakpoint
`@media (max-width: 700px)` — stacks sidebar above content, shows hamburger nav.

## Colours
- Background: `#eee`
- Nav hover: `#bcd6f0`
- Links: `#06d`
- Headings: `#222`
- Contact form heading: `#fa9229`
- Header background: `#06d`
