﻿using Docs.WebApp.Models;
using Docs.WebApp.Models.Attributes;
using Docs.WebApp.Models.Enumerations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;

namespace Docs.WebApp.Pages.Documentation.Net2Linux
{
    public partial class _Base_Page : IDisposable
    {

        private const string PROJECT_KEY = "project";
        private const string SETUP_KEY = "setup";
        private const string SUBMITTED_KEY = "submit";

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public Net2LinuxState State { get; set; }

        [Inject]
        public IJSRuntime JS { get; set; }

        bool isSubmitted;
        bool isProjectTypeDropShowing;
        bool isSetupTypeDropShowing;

        protected override void OnInitialized()
        {
            RefreshProjectType(NavigationManager.GetQueryParam(PROJECT_KEY));
            RefreshVmSetupType(NavigationManager.GetQueryParam(SETUP_KEY));
            RefreshIsSubmitted(NavigationManager.GetQueryParam(SUBMITTED_KEY));
            base.OnInitialized();
            NavigationManager.LocationChanged += LocationChanged;
        }

        void SwitchProjectTypeDrop()
        {
            isProjectTypeDropShowing = !isProjectTypeDropShowing;
            isSetupTypeDropShowing = false;
        }

        void SwitchSetupTypeDrop()
        {
            isSetupTypeDropShowing = !isSetupTypeDropShowing;
            isProjectTypeDropShowing = false;
        }

        private void LocationChanged(object sender, LocationChangedEventArgs e)
        {
            RefreshProjectType(e.GetQueryParam(PROJECT_KEY));
            RefreshVmSetupType(e.GetQueryParam(SETUP_KEY));
            RefreshIsSubmitted(e.GetQueryParam(SUBMITTED_KEY));
        }

        string GetSummary<TEnum>(Enum val)
            where TEnum : struct, Enum
        {
            var field = typeof(TEnum).GetField(val.ToString());
            var attr = (SummaryAttribute)Attribute.GetCustomAttribute(field, typeof(SummaryAttribute));
            return attr?.Summary;
        }

        void SelectProjectType(DotNetProjectType selection)
        {
            Console.WriteLine("using " + selection);
            NavigationManager.SetQueryParameter(PROJECT_KEY, selection.ToString());
        }

        void SelectSetupType(VmSetupType setup)
        {
            NavigationManager.SetQueryParameter(SETUP_KEY, setup.ToString());
        }

        void Submit()
        {
            NavigationManager.SetQueryParameter(SUBMITTED_KEY, bool.TrueString);
        }

        void RefreshProjectType(string project)
        {
            if (project is not null)
            {
                if (Enum.TryParse<DotNetProjectType>(project, out var res))
                {
                    State.ProjectType = res;
                    StateHasChanged();
                    return;
                }
                else
                    Console.WriteLine("Failed to find project type " + project);
            }
            State.ProjectType = null;
            StateHasChanged();
        }

        void RefreshVmSetupType(string setup)
        {
            if (setup is not null)
            {
                if (Enum.TryParse<VmSetupType>(setup, out var res))
                {
                    State.SetupType = res;
                    StateHasChanged();
                    return;
                }
                else
                    Console.WriteLine("Failed to find setup type " + setup);
            }
            State.SetupType = null;
            StateHasChanged();
        }

        void RefreshIsSubmitted(string submitted)
        {
            if (bool.TryParse(submitted, out var res))
            {
                isSubmitted = res;
                StateHasChanged();
            }
            else
                Console.WriteLine("Failed to parse submission status: " + submitted);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= LocationChanged;
        }
    }
}
