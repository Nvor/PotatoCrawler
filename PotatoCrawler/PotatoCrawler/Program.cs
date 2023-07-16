using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Playwright;
using PotatoCrawler.Dtos;
using PotatoCrawler.Helpers;
using PotatoCrawler.Scraping;

namespace PotatoCrawler
{
    internal class Program
    {
        private const string dumpLocation = "G://PotatoCrawler/";

        static async Task Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            builder.Configuration.Sources.Clear();
            builder.Configuration.AddConfiguration(config);

            var settings = config.GetRequiredSection("Settings").Get<Settings>();

            using IHost host = builder.Build();

            Console.WriteLine("EXECUTING POTATO CRAWLER");
            Thread.Sleep(250);

            var query = QueryBuilder.BuildQuery();
            if (settings != null)
            {
                query.DumpLocation = settings.DumpLocation;
            }

            InitiateSummary(query);

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

        private static void InitiateSummary(QueryDto query)
        {
            Console.Clear();
            Console.WriteLine($"Selected name: {query.FullName}");
            Console.WriteLine("Selected locations:");
            if (query.Locations != null && query.Locations.Length > 0)
            {
                for (int i = 0; i < query.Locations.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {query.Locations[i]}");
                }
            }
            else Console.WriteLine("None");
            Console.WriteLine($"\nInitiating search for {query.FullName}...");
            Console.WriteLine($"Dumping content at: {query.DumpLocation}");
        }
    }

    public class Settings
    {
        public required string DumpLocation { get; set; }
    }
}