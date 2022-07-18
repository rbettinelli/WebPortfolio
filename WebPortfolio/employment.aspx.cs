using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class employment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string idx = Request.QueryString["id"];
            DataSet dbDs;

            if (!string.IsNullOrEmpty(idx))
            {
                List<string> v1 = new List<string> { "ID" };
                List<object> v2 = new List<object> { idx };
                dbDs = Com_DB.Spx_Uni("spg_GetEmp", v1, v2);
            }
            else
            {
                dbDs = Com_DB.Spx_Uni("spg_GetEmp");
            }

            Repeater1.DataSource = dbDs;
            Repeater1.DataBind();

        }
    }
}