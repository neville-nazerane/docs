using Docs.WebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Services
{
    public static class PackageRepository
    {

        static IEnumerable<Package> all;

        public static IEnumerable<Package> All
            => all ??= [
                    new()
                    {
                        Name = "Azure Public Blobs",
                        NugetName = "AzurePublicBlobs",
                        Path = "AzurePublicBlobs",
                        Description = "Utility for public azure blob containers",
                        GitRepo = "AzurePublicBlobs",
                        IsDisplayed = true,
                        HasDocumentation = true,
                    },
                    new()
                    {
                        Name = "CodeGeneratorHelpers",
                        NugetName = "CodeGeneratorHelpers.Core",
                        Path = "CodeGeneratorHelpers_Core",
                        Description = "Utility for code generation using console apps",
                        GitRepo = "Code-Generators",
                        IsDisplayed = true,
                        HasDocumentation = true,
                    },
                    new()
                    {
                        Name = "Deploy .NET on ubuntu VM",
                        Path = "Net2Linux?setup=New",
                        Description = "Deploy .NET applications into a linux VM using azure devops",
                        IsDisplayed = true,
                        HasDocumentation = true,
                    },

                    // new() {
                    //    Name = "NetCore.Apis.Consumer",
                    //    Description = "Helper to consume rest API set up on .net core.",
                    //    GitRepo = "NetCore-Apis",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "NetCore.Apis.Client.UI",
                    //    Description = "Link consumed data from NetCore.Apis.Consumer to any UI",
                    //    GitRepo = "NetCore-Apis",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "NetCore.Apis.XamarinForms",
                    //    Description = "Mapping/binding between basic types and common xamarin.forms controls using NetCore.Apis.Client.UI",
                    //    GitRepo = "NetCore-Apis",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "NetCore.Angular",
                    //    Description = "Integration between .net core web applications and angularjs, allowing for strongly typed usage of angular",
                    //    GitRepo = "netcore.angular",
                    //    IsDisplayed = true,
                    //    HasDocumentation = true
                    //},
                    // new() {
                    //    Name = "NetCore.Jwt",
                    //    Description = "A simple and straightforward jwt authentication setup",
                    //    GitRepo = "netcore.jwt",
                    //    IsDisplayed = true,
                    //    HasDocumentation = true
                    //},
                    // new() {
                    //    Name = "NetCore.Azure.Blob",
                    //    Description = "Service for azure blob storage",
                    //    GitRepo = "netCore.azure.blob",
                    //    IsDisplayed = true,
                    //    HasDocumentation = true
                    //},
                    // new() {
                    //    Name = "NetCore.ModelValidation",
                    //    Description = "Model validations helper for aspnetcore. Allows you to have validations set in places such as your      business logic with the help of NetCore.ModelValidation.Core nuget",
                    //    GitRepo = "NetCore-ModelValidation",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "NetCore.ModelValidation.Core",
                    //    Description = "Core functionality to handle model validation. Allows you to add and list errors mapped to objects and its fields",
                    //    GitRepo = "NetCore-ModelValidation",
                    //    IsDisplayed = true,
                    //    HasDocumentation = true
                    //},
                    // new() {
                    //    Name = "Apps.DependencyInjection ",
                    //    Description = "Dependency injection dedicated features for apps using Microsoft.Extensions.DependencyInjection",
                    //    GitRepo = "Apps.DependencyInjection ",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "Xamarin.Forms.DependencyInjection",
                    //    Description = "Dependency injection dedicated features for Xamarin.Forms using Microsoft.Extensions.DependencyInjection",
                    //    GitRepo = "Apps.DependencyInjection ",
                    //    IsDisplayed = true
                    //},
                    // new() {
                    //    Name = "MySql.Simple",
                    //    Description = "Written over MySql.Data, a simpiler way to use MySql in .NET Standard. Allows easy database connection and reading queried results while maintaining the disposable objects and providing access to all default MySql.Data objects.",
                    //    GitRepo = null,
                    //    IsDisplayed = true
                    //}
            ];

    }
}
