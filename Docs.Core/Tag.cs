using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Docs.Core
{
    public class Tag
    {

        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Title { get; set; }

        public int? Importance { get; set; }

    }
}
