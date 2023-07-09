using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Scraper
{
    internal interface IScraper
    {
        Task Handle(QueryDto query);
    }

    internal class Scraper : IScraper
    {
        public async Task Handle(QueryDto query)
        {

        }
    }
}
