using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuBarDemo.Implementation
{
    public static class LoginTypeFactory
    {
        public static LoginType GetLoginType(String loginType)
        {
            if (loginType == null)
            {
                return null;
            }
            if (loginType.ToUpper().Equals("ADMIN"))
            {
                return new AdminLoginType();

            }
            else if (loginType.ToUpper().Equals("ACCOUNT"))
            {
                return new AccountLoginType();

            }
            else if (loginType.ToUpper().Equals("STAFF"))
            {
                return new StaffLoginType();
            }

            return null;
        }
    }
}