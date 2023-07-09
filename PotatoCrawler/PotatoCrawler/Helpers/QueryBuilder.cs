using PotatoCrawler.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoCrawler.Helpers
{
    internal static class QueryBuilder
    {
        public static QueryDto BuildQuery()
        {
            var fullName = GetFullName();
            QueryDto query = new QueryDto()
            {
                FullName = fullName
            };

            query.Locations = GetLocations();

            return query;
        }

        private static string GetFullName()
        {
            Console.Write("Enter full name to search for: ");
            var fullName = Console.ReadLine();

            if (string.IsNullOrEmpty(fullName))
            {
                throw new Exception("Full name is required");
            }

            return fullName;
        }

        private static string[] GetLocations()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Note: To search multiple locations independently, separate the locations with a comma"
                + "\n(e.g. \"New York, Philadelphia\")");
            sb.AppendLine("Enter locations: ");

            Console.Write(sb.ToString());

            var selectedLocations = Console.ReadLine();
            if (string.IsNullOrEmpty(selectedLocations))
            {
                return Array.Empty<string>();
            }

            var locations = selectedLocations
                .Split(',')
                .Select(l => l.Trim())
                .ToArray();

            return locations;
        }
    }
}
