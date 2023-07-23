using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources.Dtos
{
    internal class GoogleContent : IContent
    {
        public IList<string>? InstagramRefs { get; set; }
        public IList<string>? TwitterRefs { get; set; }
        public IList<string>? FacebookRefs { get; set; }
    }
}
