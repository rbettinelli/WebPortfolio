using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class about : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmp();
            LoadEdu();
        }

        protected void LoadEmp()
        {
            DataSet dbDs = Com_DB.Spx_Uni("spg_GetEmp");
            
            foreach (DataRow dr in dbDs.Tables[0].Rows) 
            {

                HtmlGenericControl t = new HtmlGenericControl { TagName = "div" };

                HtmlGenericControl t1 = new HtmlGenericControl { TagName = "h4" };
                t1.InnerText = dr["EmpComp"].ToString() + " ["+ dr["EmpSpanDate"].ToString() + "]";
                t.Controls.Add(t1);

                HtmlGenericControl t2 = new HtmlGenericControl { TagName = "h6" };
                t2.InnerText = dr["EmpTitle"].ToString();
                t.Controls.Add(t2);


                List<string> v1 = new List<string> { "EmpID" };
                List<object> v2 = new List<object> { dr["ID"].ToString() };
                DataSet dbDs1 = Com_DB.Spx_Uni("spg_GetEmpPoints", v1, v2);

                HtmlGenericControl ul = new HtmlGenericControl { TagName = "ul" };

                foreach (DataRow dr1 in dbDs1.Tables[0].Rows)
                {
                    HtmlGenericControl newLi = new HtmlGenericControl("li");
                    newLi.InnerText = dr1["EmpPoint"].ToString();
                    ul.Controls.Add(newLi);
                }

                t.Controls.Add(ul);
                emp.Controls.Add(t);

            }


        }

        protected void LoadEdu()
        {
            DataSet dbDs = Com_DB.Spx_Uni("spg_GetEdu");
            foreach (DataRow dr in dbDs.Tables[0].Rows)
            {

                HtmlGenericControl t = new HtmlGenericControl { TagName = "div" };

                HtmlGenericControl t1 = new HtmlGenericControl { TagName = "h4" };
                t1.InnerText = dr["EmpComp"].ToString() + " [" + dr["EmpSpanDate"].ToString() + "]";
                t.Controls.Add(t1);

                HtmlGenericControl t2 = new HtmlGenericControl { TagName = "h6" };
                t2.InnerText = dr["EmpTitle"].ToString();
                t.Controls.Add(t2);

                List<string> v1 = new List<string> { "EduID" };
                List<object> v2 = new List<object> { dr["ID"].ToString() };
                DataSet dbDs1 = Com_DB.Spx_Uni("spg_GetEduPoints", v1, v2);

                HtmlGenericControl ul = new HtmlGenericControl { TagName = "ul" };

                foreach (DataRow dr1 in dbDs1.Tables[0].Rows)
                {
                    HtmlGenericControl newLi = new HtmlGenericControl("li");
                    newLi.InnerText = dr1["EduPoint"].ToString();
                    ul.Controls.Add(newLi);
                }

                t.Controls.Add(ul);
                edu.Controls.Add(t);

            }
        }

    }
}