using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace DevBootCampBasicTemplate.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceError("If you're seeing this, something bad happened");
            return View();
        }

        public ActionResult SlowResponse()
        {
            ViewBag.Message = "Your application description page.";
 

            using (client)
            {
                try
                {
                    var response = client.GetAsync("https://jebrook-reverseproxy2.azurewebsites.net/oversize_pdf_test_0.pdf").Result;
                    System.Threading.Thread.Sleep(30000);
                    ViewBag.Message = "Response from the remote endpoint : " + response.Content;
                }
                catch (Exception e)
                {
                    ViewBag.Message = ("Exception : " + e.ToString());
                }

            }

            return View();
        }

        public ActionResult Exception()
        {
            //throw an unhandled exception 

            IntPtr ptr = new IntPtr(123);
            Marshal.StructureToPtr(123, ptr, true);


            return View();
        }

        public ActionResult TLSandSSL()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            using (client)
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                    var response = client.GetAsync("https://www.wellsfargo.com").Result;
                    ViewBag.Message = "Response from the remote endpoint : " + response;
                }
                catch (Exception e)
                {
                    ViewBag.Message = ("Exception : " + e.ToString());
                }
            }
            return View();
        }

    }
}