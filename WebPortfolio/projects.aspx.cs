using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            DataSet dbDs;


            //List<string> v1 = new List<string>({ });
            //List<object> v2 = new List<object>({ });


            dbDs = Com_DB.Spx_Uni("spg_GetApps");



            Repeater1.DataSource = dbDs;
            Repeater1.DataBind();

        }
    }
}