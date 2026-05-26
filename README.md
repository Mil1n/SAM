# SAM Modern

A modern, user-friendly desktop rework of **Steam Achievement Manager**, built with **WPF + .NET 8**.

SAM Modern keeps the familiar workflow from the legacy tool while introducing a cleaner architecture, improved UX, and safer-by-default runtime behavior.

---

## 🚀 Download

> **Latest Windows `.exe`**: **[Download here](PASTE_RELEASE_LINK_HERE)**
>
> Replace `PASTE_RELEASE_LINK_HERE` with your release URL (for example, a GitHub Releases asset link).

---

## ✨ Highlights

- **Modern desktop UI** (WPF)
- **Incremental migration path** from legacy SAM behavior
- **Layered architecture** for maintainability and testing
- **Safety-focused runtime design** with explicit network policy boundaries
- **Ready for CI/CD publishing** of release artifacts

---

## 🧱 Project Structure

```text
src/
  SamModern.Core            # Domain models, contracts, business rules
  SamModern.Infrastructure  # Integrations, adapters, data access
  SamModern.App             # WPF application (UI layer)
```

- **Core**: stable domain surface and abstractions
- **Infrastructure**: implementation details and external integrations
- **App**: modern desktop experience and presentation logic

---

## 🛣️ Roadmap

- [ ] Steam client adapter bridge
- [ ] Game list loading and filtering
- [ ] Achievements and stats editor screens
- [ ] Local audit log viewer
- [ ] Transparent network activity panel
- [ ] Automated release pipeline with `.exe` artifacts

---

## 🧰 Tech Stack

- **.NET 8**
- **WPF (Windows Desktop)**
- **C#**

---

## 📦 Build & Publish (Windows)

```bash
dotnet restore SamModern.sln
dotnet build SamModern.sln -c Release
dotnet publish src/SamModern.App/SamModern.App.csproj -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

Published binaries will be available under:

```text
src/SamModern.App/bin/Release/net8.0-windows/win-x64/publish/
```

---

## ⚠️ Note

This project focuses on usability, maintainability, and transparent behavior. Always use Steam-related tools responsibly and in accordance with Steam's Terms of Service.
