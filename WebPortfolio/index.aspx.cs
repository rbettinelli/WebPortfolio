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

            //List<string> v1 = new List<string> { "ProfileID" };
            //List<object> v2 = new List<object> { 1 };
            //DataSet dbDs1 = Com_DB.Spx_Uni("spg_GetProfileLinks",v1,v2);
            //if (dbDs1.Tables[0].Rows.Count > 0)
            //{
            //    Repeater1.DataSource = dbDs1;
            //    Repeater1.DataBind();
            //}
                

        }
    }
}