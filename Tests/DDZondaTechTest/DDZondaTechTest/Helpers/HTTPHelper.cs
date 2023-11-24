using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDZondaTechTest.Helpers
{
    public class HTTPHelper
    {
        private readonly RestClient _restClient = new();

        public RestResponse RequestBuilder(string url, Method method, string body = "")
        {
            var request = new RestRequest(url, method);

            request.AddBody(body);

            //If there was auth, handle auth header injection

            return _restClient.Execute(request);
        }
    }
}
