using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

using System.Data.SqlClient;
using MVC_Codebased_test_8_a;

namespace MVC_Codebased_test_8_a.Controllers.mvc 
{
    public class CodeController : Controller
    {
        // GET: Code
        private test db = new test();

        public ActionResult customersofgermany()
        {
            var customersofgermany = db.customer.Where(c => c.address == "Germany").ToList();
            return View(customersofgermany);

        }

        public ActionResult CustomerDetailsWithOrderId()
        {
            var customerDetails = (
                from c in db.Customer
                join o in db.orders on c.cust_id equals o.CustomerID
                where o.OrderID == 104
                select new CustomerOrderViewModel // Create a view model with properties you need
            {
                    CustomerID = c.CustomerID,
                    ContactName = c.ContactName,
                    OrderID = o.OrderID,
                // Add other properties as needed
            }
            ).FirstOrDefault();

            return View(customerDetails);
        }
    }
}



