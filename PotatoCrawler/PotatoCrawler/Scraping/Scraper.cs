using Microsoft.Playwright;
using PotatoCrawler.Dtos;
using PotatoCrawler.Scraping.ScrapeSources;
using PotatoCrawler.Scraping.ScrapeSources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping
{
    internal interface IScraper
    {
        Task Handle(QueryDto query);
    }

    internal class Scraper : IScraper
    {
        public async Task Handle(QueryDto query)
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();

            var scrapeGoogle = new SourceFactory().GetScrapeSource(ScrapeSource.Google);
            await scrapeGoogle.Scrape(browser, query);

            var result = Task.CompletedTask;
        }
    }
}
