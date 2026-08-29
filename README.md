[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.entity/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Entity

An AutoFaker (AutoBogus) override for the object Entity.

## Install

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Entity
```

## What you get

- `EntityOverride` — An AutoFaker (AutoBogus) override for the object Entity.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EntityOverride.CanOverride(context)` | Executes the can override operation. | A value indicating whether the operation succeeded. |
