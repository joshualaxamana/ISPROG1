using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ISPROGProject
{
    class Helper
    {
        public static string GetCon()
        {
            return ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
    }
}
