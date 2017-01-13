using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQBManager.Models
{
    public class UserInfoModel
    {
        public int ID { get; set; }
        public string UserNo { get; set; }

        public string Name { get; set; }

        public string LoginID { get; set; }

        public string Pwd { get; set; }

        public string IdentityCard { get; set; }

        public DateTime RegDatetime { get; set; }



    }
}