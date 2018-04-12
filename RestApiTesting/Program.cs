using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTesting
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class Program
    {

        static void Main(string[] args)
        {
            var client = new Client();
            client.EndPoint = @"https://restcountries.eu";
            client.Method = httpVerb.GET;
            var pData = client.PostData;
            var response = client.Request("/rest/v1/currency/eur");
        }
    }
}
