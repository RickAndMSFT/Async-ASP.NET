using System;
using System.Threading.Tasks;
using System.Web.UI;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class ProductsAsync : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            RegisterAsyncTask(new PageAsyncTask(GetProductSrvAsync));
        }

        private async Task GetProductSrvAsync()
        {
            var ProductService = new ProductService(); 
            var ProductList = await ProductService.GetProductsAsync();
            ProductGridView.DataSource = ProductList;
            ProductGridView.DataBind();
        }
    }
}