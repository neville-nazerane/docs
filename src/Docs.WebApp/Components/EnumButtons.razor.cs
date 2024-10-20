using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Docs.WebApp.Components
{
    public partial class EnumButtons<TEnum>
    {
        [Parameter] 
        public TEnum? SelectedEnum { get; set; }

        [Parameter]
        public bool IsVertical { get; set; } = true;

        [Parameter] 
        public EventCallback<TEnum> OnSelectionChanged { get; set; }

        void SelectType(TEnum enumValue)
        {
            SelectedEnum = enumValue;
            OnSelectionChanged.InvokeAsync(enumValue);
        }

        string GetName(TEnum value)
        {
            foreach (var attrs in typeof(TEnum).GetField(value.ToString())?.GetCustomAttributes())
                if (attrs is DescriptionAttribute desc)
                    return desc.Description;

            return value.ToString();
        }

    }
}
