using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class projectMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet dbDs = Com_DB.Spx_Uni("spg_GetApps");
            Repeater1.DataSource = dbDs;
            Repeater1.DataBind();

        }

        protected void OnSelectedIndexChanged(object sender, RepeaterCommandEventArgs e)
        {
            string selectedId = e.CommandArgument.ToString();
            Response.Redirect("~/projects.aspx?id=" + selectedId);

        }

    }




}