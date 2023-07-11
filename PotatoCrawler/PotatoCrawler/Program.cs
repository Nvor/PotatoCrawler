using Microsoft.Playwright;
using PotatoCrawler.Helpers;
using PotatoCrawler.Scraping;

namespace PotatoCrawler
{
    internal class Program
    {
        private const string dumpLocation = "G://PotatoCrawler/";

        static async Task Main(string[] args)
        {
            

            Console.WriteLine("EXECUTING POTATO CRAWLER");
            Thread.Sleep(250);

            var query = QueryBuilder.BuildQuery();

            //Console.WriteLine("\nSearch Parameters:\n--------------------");
            //Console.WriteLine($"Selected name: {query.FullName}");

            //Console.WriteLine("Selected locations:");
            //if (query.Locations != null && query.Locations.Length > 0)
            //{
            //    for (int i = 0; i < query.Locations.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1}. {query.Locations[i]}");
            //    }
            //}
            //else Console.WriteLine("None");
            
            ////foreach (var location in query.Locations)
            ////{
            ////    Console.WriteLine($"Selected locations: {location} ");
            ////}

            //Console.WriteLine($"\nInitiating search for {query.FullName}...");

            //using var playwright = await Playwright.CreateAsync();

            //await using var browser = await playwright.Chromium.LaunchAsync();

            //var page = await browser.NewPageAsync();
            //await page.GotoAsync("https://reddit.com");
            ////await page.ScreenshotAsync(new() { Path = dumpLocation });

            ////TEST 1 - navigate to instagram profile, download profile picture
            //await page.GotoAsync("https://www.instagram.com/");
            //Thread.Sleep(3000);

            //var images = page.Locator("img");
            //for (int i = 5; i < 10; i++)
            //{
            //    await images.Nth(i).ScreenshotAsync(new() { Path = dumpLocation + $"img{i}.png"});
            //}

            //await page.ScreenshotAsync(new() { Path = dumpLocation });

            var scraper = new Scraper();
            await scraper.Handle(query);
        }
    }
}