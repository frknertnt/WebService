using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebServiceApp.context;
using WebServiceApp.entities;
using WebServiceApp.security;

namespace WebServiceApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //[WebMethod]
        //public OutputType AddNewProduct(Product product, Security security)
        //{
        //    string cryptodata = "A83F96B7-9FBE-4149-A773-0268989EF76F" + security.PrivateValue.ToString() + security.TokenTime;
        //    if (security.ClientKey == SHA.SHA256Create(cryptodata))
        //    {
        //        using (DatabaseLogicLayer dll = new DatabaseLogicLayer())
        //        {
        //            if (dll.ProducttIdentityControl(product.Identify) == OutputType.NewProduct)
        //            {
        //                return dll.AddProduct(product);
        //            }
        //            else
        //                return OutputType.RegisteredProduct;
        //        }
        //    }
        //    else
        //        return OutputType.SecurityError;

        //}

        public Security SecuritySoapHeader;

        [WebMethod]
        [SoapHeader("SecuritySoapHeader",Required = true)]
        public OutputType EditProduct(Product product)
        {
            if (SecuritySoapHeader.Control())
            {
                using (DatabaseLogicLayer dll = new DatabaseLogicLayer())
                {
                    if (dll.ProducttIdentityControl(product.Identify) == OutputType.RegisteredProduct)
                    {
                        return dll.EditProduct(product);
                    }
                    else
                        return OutputType.ProductNotFound;
                }
            }
            else
                return OutputType.SecurityError;
        }
        [WebMethod]
        public OutputType DeleteProduct(string productIdentity)
        {
            using(DatabaseLogicLayer dll = new DatabaseLogicLayer())
            {
                if (dll.ProducttIdentityControl(productIdentity) == OutputType.RegisteredProduct)
                {
                    return dll.DeleteProduct(productIdentity);
                }
                else
                    return OutputType.ProductNotFound;
            }
        }
        [WebMethod]
        [SoapHeader("SecuritySoapHeader", Required = true)]
        public List<Product> GetProducts()
        {
            if (SecuritySoapHeader.Control())
            {
                using (DatabaseLogicLayer dll = new DatabaseLogicLayer())
                {
                    return dll.GetProducts();
                }
            }
            else 
                return new List<Product>();
                
        }
        [WebMethod]
        public Product GetProductByID(string productIdentity)
        {
            using (DatabaseLogicLayer dll = new DatabaseLogicLayer())
            {
                if (dll.ProducttIdentityControl(productIdentity) == OutputType.RegisteredProduct)
                    return dll.GetProductsByID(productIdentity);
                else
                    return new Product();
            }
        }
    }
}
