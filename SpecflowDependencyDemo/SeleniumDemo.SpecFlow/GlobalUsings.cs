// Global using directives

global using BoDi;
global using FluentAssertions;
global using SeleniumDemo.POM.Pages;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(5)]