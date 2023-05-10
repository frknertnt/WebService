using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.entities
{
    public enum OutputType
    {
        TransactionSuccessfull = 71770001,
        TransactionFailed = 71770002,
        Undefined = 71770003,
        RegisteredProduct = 71770004,
        NewProduct = 71770005,
        ProductNotFound = 71770006,
        SecurityError = 71770007
    }
}