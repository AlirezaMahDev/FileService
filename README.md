# FileService (Parto.Extensions.File)

Lightweight set of .NET/C# libraries that provide file-related extensions, JSON helpers, and a small set of data storage abstractions / implementations (table, collection, stack). The repository is organized as multiple projects so you can pick only the pieces you need (abstractions vs implementations).

Repository language: C# (100%)

## Project goals
- Provide simple, reusable abstractions for file-related operations.
- Ship implementations for common patterns (JSON serialization helpers and simple data stores such as table, collection and stack).
- Keep core contracts (Abstractions) separate from concrete implementations so consumers can depend only on interfaces if they prefer to provide custom implementations.

## Repository layout
- AlirezaMahDev.FileService.slnx — solution container for all projects.
- src/
  - Parto.Extensions.File — core file-related utilities and extensions.
  - Parto.Extensions.File.Abstractions — core interfaces and contracts for the file utilities.
  - Parto.Extensions.File.Json — JSON helpers and serializers (concrete JSON helpers for reading/writing data).
  - Parto.Extensions.File.Json.Abstractions — JSON-related interfaces.
  - Parto.Extensions.File.Data — shared data helpers and utilities used by data implementations.
  - Parto.Extensions.File.Data.Abstractions — data-layer interfaces and contracts.
  - Parto.Extensions.File.Data.Collection — concrete collection-based data implementation.
  - Parto.Extensions.File.Data.Collection.Abstractions — interfaces for collection data store.
  - Parto.Extensions.File.Data.Stack — concrete stack-based data implementation.
  - Parto.Extensions.File.Data.Stack.Abstractions — interfaces for stack data store.
  - Parto.Extensions.File.Data.Table — concrete table-based data implementation.
  - Parto.Extensions.File.Data.Table.Abstractions — interfaces for table data store.

Note: each "Abstractions" project is intended to hold only interfaces and DTOs so other projects or consumers can depend on only the contracts.

## Requirements
- .NET SDK (version compatible with the projects in this solution — typically .NET 6 / .NET 7 or later). If you need a specific SDK version, add or check a global.json in the repo (not present by default).

## Getting started
1. Clone the repository:
   git clone https://github.com/AlirezaMahDev/FileService.git
2. Open the solution:
   - Use Visual Studio / Rider / VS Code
   - Or from the command line:
     cd FileService
     dotnet build

3. Add references to the projects you need:
   - If you use the implementation packages, reference the corresponding Abstractions first (or reference the implementation project which typically references its abstractions).
   - Example (from your project folder):
     dotnet add reference ../FileService/src/Parto.Extensions.File/Parto.Extensions.File.csproj
   - Or add as project-to-project references inside your solution.

## Usage ideas (high level)
- Depend on the Abstractions package in libraries that only require contracts.
- Use the Json helpers for convenient JSON (de-)serialization to/from files.
- Use the Data.* implementations for simple in-process data stores backed by files (table, collection or stack semantics).
- The libraries are designed to be small and lightweight — ideal for small services, tools, or for bootstrapping simple persistence without a full database.

Since this README is generated from repository structure, consult each project's source code for exact public APIs, interfaces, and extension method names.

## Building & Testing
- Build: dotnet build
- Restore: dotnet restore
- Tests: There are no test projects included in the top-level src/ tree (if you add tests, keep them in a tests/ folder and reference projects from src/).

## Contributing
Contributions are welcome:
- Open an issue to discuss bugs or feature requests.
- Fork the repo, create a branch for your change, and submit a pull request.
- Keep changes small and focused and include unit tests where appropriate.

Suggested PR workflow:
1. Fork
2. Create a feature branch
3. Add or update tests
4. Open a PR with a clear description of what the change does and why

## Recommendations / Next steps for repository owner
- Add a LICENSE file to clarify usage terms.
- Add a concise Developer or CONTRIBUTING guide with build matrix (CI), target framework(s), and a recommended .NET SDK version (via global.json).
- Provide API usage examples in each subproject's README (public surface area / common wiring patterns).
- Add automated CI (e.g., GitHub Actions) to run build and tests on PRs.

## Authors & Maintainers
- Primary author / maintainer: AlirezaMahDev
  - GitHub: https://github.com/AlirezaMahDev

## Acknowledgements
This repository organizes file utilities and small data-store implementations into clear abstraction and implementation packages for flexible consumption across .NET projects.

If you want, I can produce per-project README files that list the public types and quick usage snippets by reading the source files.
