using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeoLocalization.Controllers
{
    public class LocalizarController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ip1 = string.Empty;
            ViewBag.ip2 = string.Empty;
            ViewBag.defaultgateway = string.Empty;
            ViewBag.ip4 = string.Empty;
            ViewBag.dnsServer = string.Empty;
            ViewBag.ip6 = string.Empty;
            ViewBag.server_IPv6_address = string.Empty;

            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"] != null)
                ViewBag.ip1 = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"];

            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ViewBag.ip2 = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();

            if (System.Web.HttpContext.Current.Request.UserHostAddress.Length != 0)
                ViewBag.defaultgateway = System.Web.HttpContext.Current.Request.UserHostAddress;

            if (System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] != null)
                ViewBag.ip4 = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();

            if (System.Web.HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"] != null)
                ViewBag.dnsServer = System.Web.HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"].ToString();

            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_CLUSTER_CLIENT_IP"] != null)
                ViewBag.ip6 = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_CLUSTER_CLIENT_IP"].ToString();

            ViewBag.server_IPv6_address = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.GetValue(0).ToString();

            if (Request.ServerVariables["X-Forwarded-For"] != null)
                ViewBag.ip8 = Request.ServerVariables["X-Forwarded-For"];

            return View();
        }
	}
}