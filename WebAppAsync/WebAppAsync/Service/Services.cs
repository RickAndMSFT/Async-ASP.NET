using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Threading;
using WebAppAsync.Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Configuration;
using WebAppAsync.Service;

namespace WebAppAsync.Service
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

    public class ProductService
    {
        public async Task<List<Product>> GetProductsAsync(
            CancellationToken cancelToken = default(CancellationToken))
        {
            var uri = Util.getServiceUri("products");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri, cancelToken);
                return (await response.Content.ReadAsAsync<List<Product>>());
            }

        }

        public List<Product> GetProducts()
        {
            var uri = Util.getServiceUri("products"); ;
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Product>>(
                    webClient.DownloadString(uri)
                );
            }
        }
    }

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