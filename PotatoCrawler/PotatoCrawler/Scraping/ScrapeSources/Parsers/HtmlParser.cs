using PotatoCrawler.Scraping.ScrapeSources.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources.Parsers
{
    internal abstract class HtmlParser
    {
        public abstract IContent ParseHtml(string html);
    }
}
