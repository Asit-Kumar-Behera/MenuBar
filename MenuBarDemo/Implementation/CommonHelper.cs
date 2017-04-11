using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MenuBarDemo.Implementation
{
    public static class CommonHelper
    {
        public static StringBuilder CreateSubMenuItem(string link, string linkText)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<li class='current'><a href = '{0}'><i class='icon-angle-right'></i>{1}</a></li>", link, linkText);

            return sb;
        }

        public static bool ExactMatch(string input, string match)
        {
            return Regex.IsMatch(input, string.Format(@"\b{0}\b", Regex.Escape(match)));
        }
    }
}