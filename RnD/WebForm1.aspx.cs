using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RnD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var pattern = new Regex(@"(^172\.\d{1,3}\.\d{1,3}.\d{1,3}$)|(^192\.\d{1,3}\.\d{1,3}.\d{1,3}$)|(^10\.\d{1,3}\.\d{1,3}.\d{1,3}$)");
                string ip;
                ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (ip == string.Empty || ip == null)
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                if (!pattern.IsMatch(ip))
                {
                    imgAdmin.Visible = false;
                }
                txtIP.Value = ip;
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}