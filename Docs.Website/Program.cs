using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace Docs.Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(ExternalConfiguration())
                .UseStartup<Startup>();

        static IConfiguration ExternalConfiguration()
            => KeyVaultConfiguration() ?? FileConfiguration();

        static IConfiguration FileConfiguration()
            => new ConfigurationBuilder()
                    .AddJsonFile(
                            Path.Combine(Directory.GetCurrentDirectory(), 
                                            @"..\secrets\nev_docs.json"), true)
                    .Build();

        static IConfiguration KeyVaultConfiguration()
        {
            var vaultEndPoint = Environment.GetEnvironmentVariable("KEYVAULT_ENDPOINT");
            if (vaultEndPoint == null) return null;
            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(
                        new KeyVaultClient.AuthenticationCallback(
                            azureServiceTokenProvider.KeyVaultTokenCallback));
            return new ConfigurationBuilder()
                    .AddAzureKeyVault(vaultEndPoint, keyVaultClient, 
                                        new DefaultKeyVaultSecretManager())
                    .Build();
        }

    }
}
