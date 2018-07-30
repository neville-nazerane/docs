using Docs.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Models
{
    public class SearchResults
    {

        public IEnumerable<Package> Packages { get; set; }

        public Dictionary<string, IEnumerable<Package>> GitRepos { get; set; }

    }
}
