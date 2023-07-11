using Microsoft.Playwright;
using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources
{
    /// <summary>
    /// Quick scrape to discover further sources.
    /// Source friendliness to Crawlers: Not friendly.
    /// </summary>
    internal class ScrapeGoogle : IScrapeSource
    {
        public string SourceName { get; } = "Google";

        public async Task Scrape(IBrowser browser, QueryDto query)
        {
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://google.com/search?q=Joe+Biden");
        }
    }
}
