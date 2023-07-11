using PotatoCrawler.Scraping.ScrapeSources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraping.ScrapeSources
{
    internal interface ISourceFactory
    {
        IScrapeSource GetScrapeSource(ScrapeSource source);
    }

    internal class SourceFactory : ISourceFactory
    {
        public IScrapeSource GetScrapeSource(ScrapeSource source)
        {
            IScrapeSource scrapeSource;

            switch (source)
            {
                case ScrapeSource.Google:
                    scrapeSource = new ScrapeGoogle();
                    break;
                default:
                    throw new Exception("Invalid scrape source");
            }

            return scrapeSource;
        }
    }
}
