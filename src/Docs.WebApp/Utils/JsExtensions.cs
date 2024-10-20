using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Docs.WebApp.Utils
{
    public static class JsExtensions
    {

        public static ValueTask ToggleDropdownAsync(this IJSRuntime js, string id)
            => js.InvokeVoidAsync("window.toggleDropdown", id);


    }
}
