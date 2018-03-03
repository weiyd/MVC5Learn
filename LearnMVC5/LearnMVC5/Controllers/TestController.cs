using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMVC5.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "控制器直接返回的字符串";
        }
    }
}