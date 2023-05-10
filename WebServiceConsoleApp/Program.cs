using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebServiceConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1-yeni ürün ekleme işlemi
            Random rnd = new Random();

            ProductWebServis.Security webSecurity = new ProductWebServis.Security();
            webSecurity.PrivateValue = rnd.Next(0, int.MaxValue);
            webSecurity.TokenTime = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");


            webSecurity.ClientKey = "A83F96B7-9FBE-4149-A773-0268989EF76F" + webSecurity.PrivateValue.ToString() + webSecurity.TokenTime;//client keyim okunabilir

            webSecurity.ClientKey = SHA.SHA256Create(webSecurity.ClientKey);//var olan client key im okunabilirken burada üstüne hashlanmis datayı bastım

            ProductWebServis.WebService1 webService = new ProductWebServis.WebService1();

            ProductWebServis.OutputType returntype = webService.AddNewProduct(new ProductWebServis.Product()
            {
                //ID identity artıyor değer vermemize gerek yok
                Description = "Telefon",
                Explanation = "Akıllı Telefon",
                Stock = 100,
                Identify = "ABCDEFG"
            },webSecurity);
            Console.Read();
        }
    }
}
