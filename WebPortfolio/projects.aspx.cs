using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet dbDs;

            string idx = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(idx)) {
                List<string> v1 = new List<string> {"ID" };
                List<object> v2 = new List<object> {idx };
                dbDs = Com_DB.Spx_Uni("spg_GetApps",v1, v2);

                List<string> v11 = new List<string> { "APPID" };
                List<object> v21 = new List<object> { idx };
                DataSet dbDs1 = Com_DB.Spx_Uni("spg_GetApps_Files", v11, v21);

                Repeater2.DataSource = dbDs1;
                Repeater2.DataBind();

            } else
            {
                dbDs = Com_DB.Spx_Uni("spg_GetApps");
            }
  
            Repeater1.DataSource = dbDs;
            Repeater1.DataBind();

        }


        protected void Rptr_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Image i = e.Item.FindControl("Image1") as Image;
                Panel p = e.Item.FindControl("Panel1") as Panel;
                p.Visible = false;
                i.Visible = true;
                if (String.IsNullOrEmpty(i.ImageUrl)) {
                    i.Visible = false;
                    p.Visible = true;
                }

            }
        }

        protected void Rptr_ItemCommand(Object Sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ShowPic")
            {

                Image img = (Image)e.Item.FindControl("Image1");
                ImgFull.ImageUrl = img.ImageUrl;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalPic();", true);

            }
        }

    }
}