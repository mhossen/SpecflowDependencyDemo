// Global using directives

global using BoDi;
global using Microsoft.Playwright;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(5)]