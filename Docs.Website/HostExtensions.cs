using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.Website
{
    public static class HostExtensions
    {

        const string urlKey = "LOCAL_URL";
        const string vaultKey = "KEYVAULT_ENDPOINT";
        const string jsonPath = @"..\secrets\nev_docs.json";

        public static IWebHostBuilder UseUrlsIfExists(this IWebHostBuilder builder)
        {
            var urls = Environment.GetEnvironmentVariable(urlKey)?.Split(";");
            if (urls != null) builder.UseUrls(urls);
            return builder;
        }

        public static IWebHostBuilder UseExternalConfiguration(this IWebHostBuilder builder)
            => builder.UseConfiguration(KeyVaultConfiguration() ?? FileConfiguration());

        static IConfiguration FileConfiguration()
            => new ConfigurationBuilder()
                    .AddJsonFile(
                            Path.Combine(Directory.GetCurrentDirectory(), jsonPath), true)
                    .Build();

        static IConfiguration KeyVaultConfiguration()
        {
            string vaultEndPoint = Environment.GetEnvironmentVariable(vaultKey);
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
