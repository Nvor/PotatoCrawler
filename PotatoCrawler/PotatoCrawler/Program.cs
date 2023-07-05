using Microsoft.Playwright;

namespace PotatoCrawler
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync();

            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://reddit.com");
            //await page.ScreenshotAsync(new() { Path = "screenshot.png" });
        }
    }
}