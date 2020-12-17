using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using Job_search.Core;

namespace Job_search.Sites
{
    class HeadHunterParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            // bloko-link HH-LinkModifier
            // bloko-link HH-LinkModifier HH-VacancySidebarTrigger-Link HH-VacancySidebarAnalytics-Link
            // bloko-link HH-LinkModifier HH-VacancySidebarTrigger-Link HH-VacancySidebarAnalytics-Link

            var vacancy = document.QuerySelectorAll("a").Where(item => item.ClassName != null && (item.ClassName.Contains("bloko-link HH-LinkModifier") 
                            || item.ClassName.Contains("bloko-link HH-LinkModifier HH-VacancySidebarTrigger-Link HH-VacancySidebarAnalytics-Link")));

            //var vacancyLink = vacancy.OfType<IHtmlAnchorElement>().Select(m => m.Href);
            // bloko-section-header-3 bloko-section-header-3_lite

            var salary = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("bloko-section-header-3 bloko-section-header-3_lite"));

            //bloko-link bloko-link_secondary

            var company = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("bloko-link bloko-link_secondary"));

            // vacancy-serp-item__meta-info

            var city = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("vacancy-serp-item__meta-info"));

            foreach (var item in vacancy)
            {
                list.Add($"Вакансия: {item.TextContent} Ссылка: {item.GetAttribute("href")}");

            }

            //foreach (var item in salary)
            //{
            //    list.Add("Зарплата " + item.TextContent);

            //}

            return list.ToArray();
        }
    }
}
