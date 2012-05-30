using System;
using WebAppAsync.Service;

namespace WebAppAsync
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var prodService = new ProductService();
            ProductGridView.DataSource = prodService.GetProducts();
            ProductGridView.DataBind();
        }
    }
}