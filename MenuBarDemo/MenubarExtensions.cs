using MenuBarDemo.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MenuBarDemo
{
    public static class MenubarExtensions
    {
        public static MvcHtmlString CreateSubMenu(this HtmlHelper htmlHelper, string link, string linkText, string userType = null)
        {
            StringBuilder sb = new StringBuilder();
            LoginType type;
            HttpCookie cookie = HttpContext.Current.Request.Cookies["UserType"];
            if (cookie != null)
            {
                type = LoginTypeFactory.GetLoginType(cookie.Value);
                if (type != null)
                {
                    sb = type.GetSubMenu(userType, link, linkText);
                }
            }
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString CreateCommonSubMenu(this HtmlHelper htmlHelper, string link, string linkText, string userType = null)
        {
            StringBuilder sb = new StringBuilder();
            sb = CommonHelper.CreateSubMenuItem(link, linkText);
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}