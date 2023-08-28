using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _28_8_23_ASP.NET_MVC.Data
{
    public class _28_8_23_ASPNET_CommentDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _28_8_23_ASPNET_CommentDbContext() : base("name=_28_8_23_ASPNET_CommentDbContext")
        {
        }

        public System.Data.Entity.DbSet<_28_8_23_ASP.NET_MVC.Models.Comment> Comments { get; set; }
    }
}
