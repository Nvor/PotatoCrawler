using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources.Dtos
{
    internal class GoogleContent : IContent
    {
        public string[]? InstagramRefs { get; set; }
        public string[]? TwitterRefs { get; set; }
        public string[]? FacebookRefs { get; set; }
    }
}
