using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class ProjectMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet dbDs = Com_DB.Spx_Uni("spg_GetApps");
            GridView1.DataSource = dbDs;
            GridView1.DataBind();

        }
        
        protected void Grid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Attaching one onclick event for the entire row, so that it will
                // fire SelectedIndexChanged, while we click anywhere on the row.
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridView grd = (GridView)sender;
            string selectedId = "";
            foreach (GridViewRow row in grd.Rows)
            {
                if (row.RowIndex == grd.SelectedIndex)
                {
                    selectedId = row.Cells[0].Text;
                    Response.Redirect("~/projects.aspx?ID=" + selectedId, false);
                }
            } 
        }

    }




}