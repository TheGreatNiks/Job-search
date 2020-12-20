using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_search.Core;

namespace Job_search.Sites
{
    class HeadHunterSettings : IParserSettings
    {
        public HeadHunterSettings(int start, int end, string vacancy)
        {
            StartPoint = start;
            EndPoint = end;
            Vacancy = vacancy;
        }
        public string BaseUrl { get; set; } = $"https://perm.hh.ru/search/vacancy?clusters=true&no_magic=true&enable_snippets=true&salary=&st=searchVacancy&text=";
        public string Page { get; set; } = "&page={CurrentId}";
        public string Vacancy { get; set; }
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
