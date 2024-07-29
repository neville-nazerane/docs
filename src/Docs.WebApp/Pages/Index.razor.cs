using Docs.WebApp.Models;
using Docs.WebApp.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Pages
{
    public partial class Index
    {

        IEnumerable<Package> displaying;
        private string query;
        readonly IEnumerable<Package> packages;

        [CascadingParameter(Name = "routeData")]
        public RouteData Data { get; set; }

        string Query
        {
            get => query; 
            set
            {
                query = value;
                DisplayWithFilter();
            }
        }

        public Index()
        {
            packages = PackageRepository.All;
            DisplayWithFilter();
        }

        void DisplayWithFilter()
        {
            var result = packages;

            if (!string.IsNullOrEmpty(Query))
            {
                result = result.Where(p => p.Name.Contains(Query, StringComparison.OrdinalIgnoreCase)
                                        || p.Tags?.Any(t => t == Query) == true
                                        || p.GitRepo?.Contains(Query, StringComparison.OrdinalIgnoreCase) == true);
            }
            
            displaying = result.Where(p => p.IsDisplayed).ToImmutableArray();
        }

    }
}
