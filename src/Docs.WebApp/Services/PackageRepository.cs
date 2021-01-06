using Docs.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Services
{
    public static class PackageRepository
    {

        public static IEnumerable<Package> GetAll()
            => new Package[] {
                     new Package {
                        Name = "NetCore.Apis.Consumer",
                        Description = "Helper to consume rest API set up on .net core.",
                        GitRepo = "NetCore-Apis",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "NetCore.Apis.Client.UI",
                        Description = "Link consumed data from NetCore.Apis.Consumer to any UI",
                        GitRepo = "NetCore-Apis",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "NetCore.Apis.XamarinForms",
                        Description = "Mapping/binding between basic types and common xamarin.forms controls using NetCore.Apis.Client.UI",
                        GitRepo = "NetCore-Apis",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "NetCore.Angular",
                        Description = "Integration between .net core web applications and angularjs, allowing for strongly typed usage of angular",
                        GitRepo = "netcore.angular",
                        IsDisplayed = true,
                        HasDocumentation = true
                    },
                     new Package {
                        Name = "NetCore.Jwt",
                        Description = "A simple and straightforward jwt authentication setup",
                        GitRepo = "netcore.jwt",
                        IsDisplayed = true,
                        HasDocumentation = true
                    },
                     new Package {
                        Name = "NetCore.Azure.Blob",
                        Description = "Service for azure blob storage",
                        GitRepo = "netCore.azure.blob",
                        IsDisplayed = true,
                        HasDocumentation = true
                    },
                     new Package {
                        Name = "NetCore.ModelValidation",
                        Description = "Model validations helper for aspnetcore. Allows you to have validations set in places such as your      business logic with the help of NetCore.ModelValidation.Core nuget",
                        GitRepo = "NetCore-ModelValidation",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "NetCore.ModelValidation.Core",
                        Description = "Core functionality to handle model validation. Allows you to add and list errors mapped to objects and its fields",
                        GitRepo = "NetCore-ModelValidation",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "Apps.DependencyInjection ",
                        Description = "Dependency injection dedicated features for apps using Microsoft.Extensions.DependencyInjection",
                        GitRepo = "Apps.DependencyInjection ",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "Xamarin.Forms.DependencyInjection",
                        Description = "Dependency injection dedicated features for Xamarin.Forms using Microsoft.Extensions.DependencyInjection",
                        GitRepo = "Apps.DependencyInjection ",
                        IsDisplayed = true
                    },
                     new Package {
                        Name = "MySql.Simple",
                        Description = "Written over MySql.Data, a simpiler way to use MySql in .NET Standard. Allows easy database connection and reading queried results while maintaining the disposable objects and providing access to all default MySql.Data objects.",
                        GitRepo = null,
                        IsDisplayed = true
                    }
            };

    }
}
