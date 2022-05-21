using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebFileValidator
{
    internal static class Helper
    {
        internal static async Task<bool> CheckUrl(string url) {

            try
            {   
                var client = new HttpClient();
                var res = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));
                
                return res.IsSuccessStatusCode;
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }
    }
}
