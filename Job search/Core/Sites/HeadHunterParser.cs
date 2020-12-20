using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using Job_search.Core;

namespace Job_search.Sites
{
    class HeadHunterParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            int counter = 0;
            int counterSalary = 0;
            var list = new List<string>();
            var salaryList = new List<string>();
            var companyList = new List<string>();
            var cityList = new List<string>();

            var vacancy = document.QuerySelectorAll("a").Where(item => item.ClassName != null && (item.ClassName.Contains("bloko-link HH-LinkModifier") 
                            || item.ClassName.Contains("bloko-link HH-LinkModifier HH-VacancySidebarTrigger-Link HH-VacancySidebarAnalytics-Link")));

            var salary = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("vacancy-serp-item__sidebar"));

            var company = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("bloko-link bloko-link_secondary"));

            var city = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("vacancy-serp-item__meta-info"));

            foreach (var item in salary)
            {
                if (item.TextContent == "")
                {
                    salaryList.Add("Не указана");
                }
                else
                {
                    salaryList.Add(item.TextContent);
                }
            }

            foreach (var item in company)
            {
                companyList.Add(item.TextContent);
            }

            foreach (var item in city)
            {
                cityList.Add(item.TextContent);
            }

            try
            {
                foreach (var item in vacancy)
                {
                    
                    counter++;
                    list.Add($"\n{counter} Вакансия: {item.TextContent} \nЗарплата: {salaryList[counterSalary]} \nКомпания: {companyList[counter - 1]} \nГород: {cityList[counter - 1]} \nСсылка: {item.GetAttribute("href")}");
                    counterSalary += 2;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            return list.ToArray();
        }
    }
}
