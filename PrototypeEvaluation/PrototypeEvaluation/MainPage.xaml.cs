using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace PrototypeEvaluation
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string auth)
        {
            InitializeComponent();
            startAsyncLoginTask(auth);
        }

        async void GoLoginButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }


        async void startAsyncLoginTask(String auth)
        {
            VersionLabel.Text = await GetVersionAsync(auth);
        }


        public async Task<string> GetVersionAsync(string auth)
        {
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(auth));
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://mars.imagic.ch:3171/");

            client.MaxResponseContentBufferSize = 256000;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
            var address = "rest/info";

            var response = await client.GetAsync(address);

            if(response.StatusCode != HttpStatusCode.OK)
            {
                return "Login failed";
            }
            var responseContentString = response.Content.ReadAsStringAsync().Result;
            Versionclass version = JsonConvert.DeserializeObject<Versionclass>(responseContentString);
            return version.version;

        }

    }
}
