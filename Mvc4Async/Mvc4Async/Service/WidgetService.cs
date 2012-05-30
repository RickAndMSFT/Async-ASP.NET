using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Mvc4Async.Models;
using Newtonsoft.Json;

namespace Mvc4Async.Service
{
    public class WidgetService
    {
        public async Task<List<Widget>> GetWidgetsAsync(
        CancellationToken cancelToken = default(CancellationToken))
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = Util.getServiceUri("widgets");
                var response = await httpClient.GetAsync(uri, cancelToken);
                return (await response.Content.ReadAsAsync<List<Widget>>());
            }
        }

        // The following method shows the simplest possible async GetAsync
        // which doesn't use the CancellationToken
        public async Task<List<Widget>> GetWidgetsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = Util.getServiceUri("widgets");
                var response = await httpClient.GetAsync(uri);
                return (await response.Content.ReadAsAsync<List<Widget>>());
            }

        }

        public List<Widget> GetWidgets()
        {
            var uri = Util.getServiceUri("widgets");
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Widget>>(
                    webClient.DownloadString(uri)
                );
            }
        }
    }
}