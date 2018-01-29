using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CaliburnTemplate.Models
{
    interface IPaddingService
    {
        Task<string> LeftPad(string text);
    }

    class PaddingService : IPaddingService
    {
        public PaddingService()
        {
            this.Client = new HttpClient();
        }

        public HttpClient Client { get; }

        public async Task<string> LeftPad(string text)
        {
            dynamic result = JsonConvert.DeserializeObject(await Client.GetStringAsync("https://api.left-pad.io/?len=30&ch==&str=" + text));
            return result.str;
        }
    }
}
