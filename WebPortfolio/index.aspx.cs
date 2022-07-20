using System;
using System.Collections.Generic;
using System.Data;


namespace WebPortfolio
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PageInit();
            }
        }

        protected void PageInit()
        {
            DataSet dbDs = Com_DB.Spx_Uni("spg_GetProfile");
            if (dbDs.Tables[0].Rows.Count > 0)
            {
               DataRow dr = dbDs.Tables[0].Rows[0];
               this.Title = dr["UserName"].ToString() + "'s Web Portfolio";
               DevImage.ImageUrl = "~/images/" + dr["UserPicture"];
               LblBio.Text = dr["UserBio"].ToString();
            }
        }
    }
}