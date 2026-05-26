# SteamAchievementManager Modernization (WPF)

This repository now contains a **WPF (.NET 8)** modernization scaffold that preserves the intent of the legacy SAM workflow while preparing a safer, more maintainable architecture.

## Goals

- Keep legacy functionality path available (game list, achievements/stats management).
- Introduce layered architecture (`Core`, `Infrastructure`, `UI`).
- Add safe-by-default runtime controls and explicit network policy surfaces.
- Enable incremental migration from legacy WinForms code.

## Solution layout

- `src/SamModern.Core` — domain models and contracts.
- `src/SamModern.Infrastructure` — Steam adapter and data services.
- `src/SamModern.App` — WPF desktop UI app.

## Current status

- Scaffolded solution and projects.
- Basic shell window with navigation placeholder.
- Dependency injection wiring.
- Initial network policy abstraction (allowlist model).

## Next steps

1. Add Steam client adapter implementation and legacy interop bridge.
2. Implement game list loading and filtering in `Core` + `Infrastructure`.
3. Add achievements/stats editing screens in WPF.
4. Add local audit log viewer and request transparency panel.

