using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace WebPortfolio
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                PageInit();
            }
        }

        protected void PageInit()
        {
            DataSet dbDs = Com_DB.Spx_Uni("spg_GetProfile");
            if (dbDs.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dbDs.Tables[0].Rows[0];
                ImgPic.ImageUrl = "~/images/" + dr["UserPicture"];
                LblName.Text = dr["UserName"].ToString();
            }

        }

        public void DisplayAjaxMessage(String txt)
        {
            LblSystemNote.Text = txt;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void LnkX_Click(object sender, EventArgs e)
        {
            LinkButton lnkX = (LinkButton) sender;

            Lnk1.CssClass = "nav-link";
            Lnk2.CssClass = "nav-link";
            Lnk3.CssClass = "nav-link";
            Lnk4.CssClass = "nav-link";
            Lnk5.CssClass = "nav-link";
            Lnk6.CssClass = "nav-link";

            switch (lnkX.ID)
            {
                case "Lnk1":
                    Lnk1.CssClass = "nav-link active";
                    Response.Redirect("index.aspx");
                    break;
                case "Lnk2":
                    Lnk2.CssClass = "nav-link active";
                    Response.Redirect("employment.aspx");
                    break;
                case "Lnk3":
                    Lnk3.CssClass = "nav-link active";
                    Response.Redirect("education.aspx");
                    break;
                case "Lnk4":
                    Lnk4.CssClass = "nav-link active";
                    Response.Redirect("ProjectMain.aspx");
                    break;
                case "Lnk5":
                    Lnk5.CssClass = "nav-link active";
                    Response.Redirect("contact.aspx");
                    break;
                case "Lnk6":
                    Lnk6.CssClass = "nav-link active";
                    Response.Redirect("about.aspx");
                    break;
                default:
                    Lnk1.CssClass = "nav-link active";
                    Response.Redirect("index.aspx");
                    break;

            }

        }

    }
}