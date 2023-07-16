using HtmlAgilityPack;
using PotatoCrawler.Scraping.ScrapeSources.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources.Parsers
{
    internal class GoogleHtmlParser : HtmlParser
    {
        private const int depth = 1;

        public override IContent ParseHtml(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var rootNode = doc.DocumentNode as HtmlNode;

            return new GoogleContent();
        }
    }
}
