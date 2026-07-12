# Steam Achievement Manager

![Build](https://github.com/Mil1n/SAM/actions/workflows/build.yml/badge.svg?branch=master)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6)
![.NET](https://img.shields.io/badge/.NET_Framework-4.8-512BD4)
![License](https://img.shields.io/badge/license-zlib%2Flibpng-blue)

Steam Achievement Manager (SAM) is a lightweight Windows utility for viewing and managing achievements and statistics exposed by the Steam client.

> [!WARNING]
> SAM changes achievement and statistic data associated with your Steam account. Use it only with games you own and at your own risk. Some games, services, communities, or competitive systems may prohibit external modification of achievements or statistics.

## Features

- Browse games detected through the running Steam client.
- Search and filter the game library.
- View locked and unlocked achievements.
- Update achievements and editable statistics.
- Reset statistics with explicit confirmation.
- Portable Windows build with no installer required.
- Resilient game-list and artwork downloads with timeouts and offline fallback.

## Requirements

- Windows 10 or newer.
- Steam installed, running, and signed in.
- .NET Framework 4.8.
- An x86-capable Windows environment.

## Usage

1. Download the latest artifact or release ZIP.
2. Extract it outside the Steam installation directory.
3. Start `SAM.Picker.exe` while Steam is running.
4. Select a game, review the proposed changes, and confirm before saving.

Do not run SAM from inside the Steam installation directory.

## Building from source

Visual Studio 2022 with the **.NET desktop development** workload is recommended.

```powershell
nuget restore SAM.sln
msbuild SAM.sln /m /p:Configuration=Release /p:Platform=x86
```

Release binaries are written to `upload/`. GitHub Actions runs the same build for pushes and pull requests targeting `master` and publishes a downloadable ZIP artifact.

## Project structure

| Project | Purpose |
| --- | --- |
| `SAM.API` | Native Steam client bindings and callback handling |
| `SAM.Picker` | Game browser and launcher |
| `SAM.Game` | Achievement and statistic manager |

## Security and privacy

- SAM communicates with the locally installed Steam client.
- Game metadata and artwork may be downloaded over HTTPS.
- This repository does not include telemetry or account credential collection.
- Review every change before applying it to Steam.

## Contributing

Bug reports and focused pull requests are welcome. Please include reproduction steps for bugs and verify that `SAM.sln` builds in `Release|x86` before submitting a change.

## Attribution

This project is based on the open-source Steam Achievement Manager by [Gibbed](https://github.com/gibbed/SteamAchievementManager). Most icons are from the [Fugue Icons](https://p.yusukekamiyamane.com/) set.

The original copyright notices and license files are retained.

## License

See [LICENSE.txt](LICENSE.txt).
