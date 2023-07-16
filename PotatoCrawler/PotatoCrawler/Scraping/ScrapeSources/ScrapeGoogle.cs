using Microsoft.Playwright;
using PotatoCrawler.Dtos;
using PotatoCrawler.Scraping.ScrapeSources.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources
{
    /// <summary>
    /// Quickly scrape top index results to discover further sources.
    /// Source friendliness to Crawlers: Not friendly.
    /// </summary>
    internal class ScrapeGoogle : IScrapeSource
    {
        public string SourceName { get; } = "Google";

        public async Task Scrape(IBrowser browser, QueryDto query)
        {
            var page = await browser.NewPageAsync();

            var name = FormatNameForQuery(query.FullName);
            await page.GotoAsync($"https://google.com/search?q={name}");

            await page.ScreenshotAsync(new() { Path = query.DumpLocation + "google.png" });
            var html = await page.ContentAsync();

            var parser = new GoogleHtmlParser();
            var links = parser.ParseHtml(html);
        }

        private string FormatNameForQuery(string fullName)
        {
            return fullName.Replace(" ", "+");
        }
    }
}
