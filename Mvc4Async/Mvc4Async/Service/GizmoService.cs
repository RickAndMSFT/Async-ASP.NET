using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Mvc4Async.Models;
using Newtonsoft.Json;

namespace Mvc4Async.Service
{
    public class GizmoService
    {
        public async Task<List<Gizmo>> GetGizmosAsync(
            // Implementation removed.
            CancellationToken cancelToken = default(CancellationToken))
        {
            var uri = Util.getServiceUri("Gizmos");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri, cancelToken);
                return (await response.Content.ReadAsAsync<List<Gizmo>>());
            }
        }

        //  Simpler API, no CancellationToken
        public async Task<List<Gizmo>> GetGizmosAsync()
        {
            var uri = Util.getServiceUri("Gizmos");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                return (await response.Content.ReadAsAsync<List<Gizmo>>());
            }
        }
        // Implementation removed.

        public List<Gizmo> GetGizmos()
        {
            var uri = Util.getServiceUri("Gizmos");
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Gizmo>>(
                    webClient.DownloadString(uri)
                );
            }
        }
    }
}