using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IQBManager.Models
{
    public class QBDbContext: DbContext
    {
      //  public DbSet<ApplicationUser> UserInfoList { get; set; }
        public QBDbContext() : base("DefaultConnection") { }

    }
}