using Docs.WebApp.Models;
using Docs.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docs.WebApp.Pages
{
    public partial class Index
    {

        IEnumerable<Package> displaying;
        private string query;
        readonly IEnumerable<Package> packages;

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
            packages = PackageRepository.GetAll();
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

            displaying = result.Where(p => p.IsDisplayed);
        }

    }
}
