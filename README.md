[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entity/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Entity

An AutoFaker override that provides identity and audit fields for `Entity` models.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Entity
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Entity;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new EntityOverride()];

CustomerEntity entity = autoFaker.Generate<CustomerEntity>();
```

The override applies to `Entity` and derived types. It assigns a GUID string to `Id` and uses one current UTC timestamp for both `CreatedAt` and `ModifiedAt`. Put a more specific matching override later in the configuration if it should replace these defaults.
