﻿using System.Web;
using System.Web.Mvc;

namespace _28_8_23_ASP.NET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
