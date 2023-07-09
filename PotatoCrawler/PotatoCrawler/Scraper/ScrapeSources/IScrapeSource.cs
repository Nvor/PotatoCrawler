using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraper.ScrapeSources
{
    internal interface IScrapeSource
    {
        string SourceName { get; }
        Task Scrape(QueryDto query);
    }
}
