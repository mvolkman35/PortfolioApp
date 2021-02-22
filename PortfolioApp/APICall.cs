using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioApp
{
    class APICall
    {
        private static HttpClient GetHttpClient(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private static async Task<T> GetAsync<T>(string url, string urlParameters, string ticker)
        {
            
            try
            {
                using (var client = GetHttpClient(url))
                {
                    HttpResponseMessage response = await client.GetAsync(urlParameters).ConfigureAwait(false);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        //create a string fixer, easiest way since json main object changes with ticker, 
                        //no need to create any complex object to adjust at runtime, just replace with generic ticker
                        //so JSON can de-serialize normally
                        Regex rgx = new Regex(ticker);
                        string jsonTickerRemoved = rgx.Replace(json, "Ticker", 1);
                        
                        var result = JsonConvert.DeserializeObject<T>(jsonTickerRemoved);

                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default(T);
            }
        }

        public static async Task<T> RunAsync<T>(string url, string urlParameters, string ticker)
        {
            return await GetAsync<T>(url, urlParameters, ticker).ConfigureAwait(false);
        }

    }
}
