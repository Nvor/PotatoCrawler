using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Helpers
{
    internal static class ConsolePrintUtils
    {
        public static void ProgramIntro()
        {
            Console.WriteLine("EXECUTING POTATO CRAWLER");
            Thread.Sleep(250);
        }

        public static void InitiateSummary(QueryDto query)
        {
            Console.Clear();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Selected name: {query.FullName}");
            sb.AppendLine("Selected locations:");
            if (query.Locations != null && query.Locations.Length > 0)
            {
                for (int i = 0; i < query.Locations.Length; i++)
                {
                    sb.AppendLine($"{i + 1}. {query.Locations[i]}");
                }
            }
            else sb.AppendLine("None");
            sb.AppendLine($"\nInitiating search for {query.FullName}...");
            sb.AppendLine($"Dumping content at: {query.DumpLocation}");

            Console.WriteLine(sb.ToString());
        }
    }
}
