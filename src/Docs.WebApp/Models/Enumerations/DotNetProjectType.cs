
using System.ComponentModel;

namespace Docs.WebApp.Models.Enumerations
{
    public enum DotNetProjectType
    {

        [Description("Web app")]
        Api,

        [Description("Background (worker app)")]
        Worker,

        [Description("Blazor client app")]
        Wasm

    }
}
