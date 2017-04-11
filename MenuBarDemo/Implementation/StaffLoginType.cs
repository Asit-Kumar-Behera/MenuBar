using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MenuBarDemo.Implementation
{
    public class StaffLoginType : LoginType
    {
        private string[] actions = { "Class", "Age Group", "Academic Age Group", "Term" };
        public override StringBuilder GetSubMenu(string userType, string link, string linkText)
        {
            StringBuilder sb = new StringBuilder();
            if (ValidateUserType(userType,linkText))
            {
                sb=CommonHelper.CreateSubMenuItem(link, linkText);
            }
            return sb;
        }

        public override bool ValidateUserType(string userType, string linkText)
        {
            if (actions.Contains(linkText))
            {
                return true;
            }
            else
            {
                return false;
            }
            //if (CommonHelper.ExactMatch(linkText,linkText))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}