using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceASPTest
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductService.WebService1 ps = new ProductService.WebService1();
            ps.SecurityValue = new ProductService.Security();
            ps.SecurityValue.Username = "demo";
            ps.SecurityValue.Password = "demo";

            ps.EditProduct(new ProductService.Product()
            {
                ID = 3
            });
        }
    }
}