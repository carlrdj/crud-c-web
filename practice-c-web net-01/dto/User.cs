using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice_c_web_net_01.dto
{
    public class User
    {
        public int use_id { get; set; }
        public string use_name { get; set; }
        public string use_email { get; set; }
        public int use_status { get; set; }
        public string use_name_uppercase { get { return use_name.ToUpper(); } }
    }
}