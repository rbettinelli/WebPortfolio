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
            } else
            {
                dbDs = Com_DB.Spx_Uni("spg_GetApps");
            }
  
            Repeater1.DataSource = dbDs;
            Repeater1.DataBind();

            string p = Server.MapPath("/images/apppics/" + idx);
            FileInfo[] files = Com_Lib.GetDirCont(p, "*.jpg");

            Repeater2.DataSource = files;
            Repeater2.DataBind();

        }

        //protected void Data_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    //Bind the inner repeater
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        //Get the repeater
        //        Repeater repeater = e.Item.FindControl("Repeater2") as Repeater;

        //        //Get the schedule date from the DataItem 
        //        string idx = Request.QueryString["id"];

               

        //    }
        //}

        public String FileSplit(object strX)
        {
            string str = (string)strX;
            char c = '\\';
            string[] pth = str.Split(c);
            string newPth = "";
            int i = 0;
            foreach (string item in pth.Reverse()) {
                if (i < 4)
                {
                    newPth = item + "/" + newPth;
                }
                i += 1;
            }

            string p = "~/" + newPth.Substring(0,newPth.Length-1);
            return p;
        }

    }
}