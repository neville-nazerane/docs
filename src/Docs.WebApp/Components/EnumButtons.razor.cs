using Microsoft.AspNetCore.Components;
using System;

namespace Docs.WebApp.Components
{
    public partial class EnumButtons<TEnum>
    {
        [Parameter] 
        public TEnum? SelectedEnum { get; set; }

        [Parameter]
        public bool IsVertical { get; set; }

        [Parameter] 
        public EventCallback<TEnum> OnSelectionChanged { get; set; }

        void SelectType(TEnum enumValue)
        {
            SelectedEnum = enumValue;
            OnSelectionChanged.InvokeAsync(enumValue);
        }
    }
}
