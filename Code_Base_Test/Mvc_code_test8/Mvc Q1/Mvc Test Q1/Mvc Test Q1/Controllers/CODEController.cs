using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Test_Q1.Models;

namespace Mvc_Test_Q1.Controllers
{
    public class CODEController : Controller { 
 


        public NorthwindEntities con = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method1()
        {

            var customersInGermany = con.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customersInGermany);

        }
        public ActionResult method2()
        {
            string v = 10248.ToString();
            return View(con.CustOrdersOrders(v));
        }
    }
}