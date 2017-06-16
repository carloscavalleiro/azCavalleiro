using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace azWebApp
{
    public partial class azWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Bemvindo ao site azCavalleiro ";
            Label2.Text = "Versão da publicação " + ConfigurationManager.AppSettings["lcVersion"];
            Label3.Text = "Versão do site       " + ConfigurationManager.AppSettings["azVersion"];
        }
    }
}