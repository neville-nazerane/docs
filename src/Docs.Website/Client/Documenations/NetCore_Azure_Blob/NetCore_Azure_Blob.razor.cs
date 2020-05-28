using Docs.Core;
using Docs.Website.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Docs.Website.Client.Documenations.NetCore_Azure_Blob
{
    public partial class NetCore_Azure_Blob
    {

        CurrentDocument Document => new CurrentDocument
        {
            TabItems = new TabItem[] { 
                new TabItem{ All = "Batman" },
                new TabItem{ All = "Dead Meat" },
            },
            Package = new Package {
            
            }
        };

    




    }
}
