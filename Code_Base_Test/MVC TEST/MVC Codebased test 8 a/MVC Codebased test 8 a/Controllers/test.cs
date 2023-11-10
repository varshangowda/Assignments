using System.Collections.Generic;

namespace MVC_Codebased_test_8_a.Controllers
{
    internal class test
    {
        internal IEnumerable<object> customer;
        internal object orders;

        public test()
        {
        }

        public IEnumerable<object> Customer { get; internal set; }
    }
}