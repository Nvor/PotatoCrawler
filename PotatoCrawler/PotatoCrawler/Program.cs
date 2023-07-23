using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using PotatoCrawler.Helpers;
using PotatoCrawler.Scraping;

namespace PotatoCrawler
{
    internal class Program
    {
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

            ConsolePrintUtils.ProgramIntro();

            var query = QueryBuilder.BuildQuery();
            if (settings != null)
            {
                query.DumpLocation = settings.DumpLocation;
            }

            ConsolePrintUtils.InitiateSummary(query);

            var scraper = new Scraper();
            await scraper.Handle(query);
        }
    }

    public class Settings
    {
        public required string DumpLocation { get; set; }
    }
}