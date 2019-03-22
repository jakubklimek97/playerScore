using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PlayerScore
{
    class parser
    {
        public parser(string apiKey) => this.apiKey = apiKey;

        public async Task<Report[]> GetReportsAsync(long startDate,ulong endDate = 0)
        {
            string reqUrl = "https://www.warcraftlogs.com:443/v1/reports/guild/Enklawa/steamwheedle-cartel/EU?";
            reqUrl += "start=" + startDate.ToString() + "&api_key=" + apiKey;
            try
            {
                HttpResponseMessage response = await client.GetAsync(reqUrl);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                tmp = null;
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
                DataContractJsonSerializer repS = new DataContractJsonSerializer(typeof(Report[]));
                tmp = repS.ReadObject(ms) as Report[];
                ms.Close();
                return Tmp;
                
            }
            catch(HttpRequestException e)
            {
            }
            return new Report[0];
        }
        private Report[] tmp;
        private static readonly HttpClient client = new HttpClient();
        string apiKey;
        string gildia = "Enklawa";
        string serwer = "steamwheedle-cartel";
        string region = "EU";

        internal Report[] Tmp { get => tmp;}
    }
}
