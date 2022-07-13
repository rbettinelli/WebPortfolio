using System;
using System.IO;
using System.Data;
using System.Web.UI.WebControls;

// ------------------------------------------------------------------------------------------------------------------
// - rbettinelli - Common Libraries For Conversion and Web Funcitons and such. 
// ------------------------------------------------------------------------------------------------------------------
// 06/15/2022 - Basic Stuff. 
// ------------------------------------------------------------------------------------------------------------------
namespace WebPortfolio
{
    public class Com_Lib
    {
        // ---------------------------------------------------------------------------
        // Date Formats
        // ---------------------------------------------------------------------------
        public const string EofyFormat = "12/31/";
        public const string Dfmt = "MM/dd/yyyy";


        // ---------------------------------------------------------------------------
        // AddToDropDown - Drop Down List Population.
        // ---------------------------------------------------------------------------
        public static void AddToDropDown(DropDownList drp, DataSet dbDs, string[] txtRow, string typ, int tableId = 0)
        {
            drp.Items.Clear();
            try
            {
                drp.Items.Add(new ListItem("Select " + typ, "0"));
                for (int x = 0; x <= dbDs.Tables[tableId].Rows.Count - 1; x++)
                {
                    ListItem li = new ListItem()
                    {
                        Text = dbDs.Tables[tableId].Rows[x][txtRow[0]].ToString(),
                        Value = dbDs.Tables[tableId].Rows[x][txtRow[1]].ToString()
                    };
                    drp.Items.Add(li);
                    drp.SelectedIndex = 0;
                }
            }
            catch (Exception) { }

        }


        // ---------------------------------------------------------------------------
        // GetDirCont
        // ---------------------------------------------------------------------------
        public static FileInfo[] GetDirCont(string fullPath, string extFilter)
        {
            DirectoryInfo dDir = new DirectoryInfo(fullPath);
            FileInfo[] files = dDir.GetFiles(extFilter);
            Array.Sort(files, new ClsCompareFileInfo());
            return files;
        }

        // ---------------------------------------------------------------------------
        // FDbl - Return Double from String
        // ---------------------------------------------------------------------------
        public static double FDbl(string txt)
        {
            double rt = 0.0;
            if (!string.IsNullOrEmpty(txt))
            {
                txt = CleanString(txt.Trim());
                Double.TryParse(txt, out rt); 
            }
            return rt;
        }

        // ---------------------------------------------------------------------------
        // FBool - Return Boolean from String
        // ---------------------------------------------------------------------------
        public static bool FBool(string txt)
        {
            bool rt = false;
            if (!string.IsNullOrEmpty(txt))
            {
                txt = CleanString(txt.Trim());
                Boolean.TryParse(txt, out rt);
            }
            return rt;
        }

        // ---------------------------------------------------------------------------
        // FInt - Return Integer from String
        // ---------------------------------------------------------------------------
        public static int FInt(string txt)
        {
            int rt = 0;

            txt = CleanString(txt.Trim());
            Int32.TryParse(txt, out rt);

            return rt;
        }

        // ---------------------------------------------------------------------------
        // CleanString - Strip unwanted Chars
        // ---------------------------------------------------------------------------
        public static string CleanString(string txt)
        {
            if (txt != null)
            {
                var strpChar = new[] { ",", "$", "/", @"\", "{", "}", " " };
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (string str in strpChar)
                    txt = txt.Replace(str, "");
            }
            return txt;
        }

        // ---------------------------------------------------------------------------
        // CdVal - String to TimeDate
        // ---------------------------------------------------------------------------
        public static DateTime CdVal(string txt)
        {
            var CdV = Convert.ToDateTime(txt);
            return CdV;
        }


    }
}
