using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Mvc4Async.Models;
using Newtonsoft.Json;

namespace Mvc4Async.Service
{
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
}