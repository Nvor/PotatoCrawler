using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraper.ScrapeSources
{
    /// <summary>
    /// Quick scrape to discover further sources.
    /// Source friendliness to Crawlers: Not friendly.
    /// </summary>
    internal class ScrapeGoogle : IScrapeSource
    {
        public string SourceName { get; } = "Google";

        public Task Scrape(QueryDto query)
        {
            return Task.CompletedTask;
        }
    }
}
