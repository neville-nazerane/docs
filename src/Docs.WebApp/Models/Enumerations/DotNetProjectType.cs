
using Docs.WebApp.Models.Attributes;
using System.ComponentModel;

namespace Docs.WebApp.Models.Enumerations
{
    public enum DotNetProjectType
    {

        [Description("Web app (API)")]
        [Summary("API")]
        Api,

        [Description("Background (worker app)")]
        [Summary("Worker")]
        Worker,

        [Description("Blazor client app")]
        [Summary("Blazor")]
        Wasm

    }
}
