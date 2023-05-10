using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Identify { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public int Stock { get; set; }
    }
}