# Standard: Cloudflare Pages Deployment

## Config file
`astro/wrangler.toml` — defines project name and assets directory.

## Build settings (in Cloudflare Pages dashboard)

| Setting | Value |
|---|---|
| Build command | `npm run build` |
| Output directory | `dist` |
| Root directory | `astro` |
| Node version | 22 (set via environment variable `NODE_VERSION=22`) |

## Environment variables

| Variable | Where set | Purpose |
|---|---|---|
| `PUBLIC_WEB3FORMS_KEY` | Cloudflare Pages dashboard + `astro/.env` locally | Contact form delivery |

## Branches

| Branch | Environment |
|---|---|
| `master` | Production (live site) — currently still legacy MVC |
| `astro-preview` | Preview (Astro site, not yet deployed) |

## Static-only output

This site uses `output: 'static'` — **no Cloudflare adapter needed**.
Cloudflare Pages serves the `dist/` folder directly as static assets.
Do not add `@astrojs/cloudflare` unless SSR is introduced (it isn't planned).

## Redirects

`astro/public/_redirects` is copied to `dist/` at build time.
Cloudflare Pages processes this file automatically for 301 redirects.
