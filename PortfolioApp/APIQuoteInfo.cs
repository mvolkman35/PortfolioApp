﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp
{
    class APIQuoteInfo
    {
        const string url = "https://api.tdameritrade.com/v1/";
        const string apiKey = "VU40WNJCOLRF5CD8ARYNFWPWXLP4NZFK";

        public static dynamic GetPriceInfo(string ticker)
        {
            string urlParameters = $"marketdata/{ticker}/quotes?apikey={apiKey}";
            var response = APICall.RunAsync<JSONParseQuote>(url, urlParameters, ticker).GetAwaiter().GetResult();
            return response;
        }
    }
}
