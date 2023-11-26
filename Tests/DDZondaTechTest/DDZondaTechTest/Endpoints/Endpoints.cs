using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDZondaTechTest.Routes
{
    public class Endpoints
    {
        public string Baseurl => "http://localhost:3001/api";

        public string GetSubdivisionsDefault(string statusCodeFilter = "", int pageNumber = 1, int pageLimit = 10, string sortParam = "") 
            => $"{Baseurl}/subdivisions/?subdivisionStatusCodeFilter{statusCodeFilter}=&pageNumber={pageNumber}&limit={pageLimit}&sortParam={sortParam}";

        public string GetSubdivisionsPageLimitQuery(int pageLimit)
           => $"{Baseurl}/subdivisions/?subdivisionStatusCodeFilter=&pageNumber=1&limit={pageLimit}&sortParam=";

        public string GetSubdivisionsStatusFilterQuery(string statusCodeFilter)
           => $"{Baseurl}/subdivisions/?subdivisionStatusCodeFilter={statusCodeFilter}&pageNumber=1&limit=5000&sortParam=";
    }
}
