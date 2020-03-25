using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;


//this would fail without user roles in Dynamics
namespace TestSend
{
    public class UnitTest1
    {
        static void Main(string[] args)
        {
            var execute = Task.Run(async () => await TestAuth());
            Task.WaitAll(execute);
        }
        static async Task TestAuth()
        {
            string api = "https://dlcrm.crm.dynamics.com";
            AuthenticationParameters ap = AuthenticationParameters.CreateFromUrlAsync(new Uri(api)).Result;

            var creds = new ClientCredential("id in azure", "secret in azure");
            AuthenticationContext authContext = new AuthenticationContext(ap.Authority);
            var token = authContext.AcquireTokenAsync(ap.Resource, creds).Result.AccessToken;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await httpClient.GetAsync(api + "/contacts?$top=1");
            }

        }
    }
}
