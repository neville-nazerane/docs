using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Docs.Core
{
    public class PackageTag
    {

        public int Id { get; set; }

        [Required]
        public int? PackageId { get; set; }
        public Package Package { get; set; }

        [Required]
        public int? TagId { get; set; }
        public Tag Tag { get; set; }

    }
}
