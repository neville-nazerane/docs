using Docs.WebApp.Models.Attributes;
using System.ComponentModel;

namespace Docs.WebApp.Models.Enumerations
{
    public enum VmSetupType
    {

        [Description("I'm setting the VM for the first time using this documentation")]
        [Summary("First time setup")]
        New,

        [Description("I have already setup the VM using this documentation in the past and want to add an app")]
        [Summary("Adding app (already setup)")]
        Adding

    }
}
