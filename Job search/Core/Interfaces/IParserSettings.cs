using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_search.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Page { get; set; }
        string Vacancy { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
