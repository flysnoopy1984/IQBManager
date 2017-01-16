using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IQBManager.Models
{
    public class QBDbContext: DbContext
    {
        public DbSet<UserInfoModel> UserInfoList { get; set; }

        public QBDbContext() : base("QBConnection") { }

    }
}