//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Data;

using System.Collections.Generic;

namespace MVC_TEST_1.Controllers
{
    public class NorthwindContext
    {
        public IEnumerable<object> Customers { get; internal set; }
        public object Orders { get; internal set; }
    }
}