using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.entities
{
    public class Security : System.Web.Services.Protocols.SoapHeader
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //public string ClientKey { get; set; }
        //public string TokenTime { get; set; }
        //public int PrivateValue { get; set; }

        public bool Control()
        {
            if (Username == "demo" && Password == "demo") //SHA256 ile şifrelediğimiz değerleri buraya yazılabilir
                return true;
            else 
                return false;
        }
    }
}