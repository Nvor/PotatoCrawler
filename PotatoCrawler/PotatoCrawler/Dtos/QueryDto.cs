using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Dtos
{
    internal class QueryDto
    {
        public required string FullName { get; set; }
        public string[]? Locations { get; set; }
        
        // Optional data points for precision
        public string[]? Miscellaneous { get; set; }
    }
}
