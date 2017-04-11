using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MenuBarDemo.Implementation
{
    public abstract class LoginType
    {
        public abstract bool ValidateUserType(string userType, string linkText);

        public abstract StringBuilder GetSubMenu(string userType,string link, string linkText);
    }
}