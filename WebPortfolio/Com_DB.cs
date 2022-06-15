using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

// ------------------------------------------------------------------------------------------------------------------
// - rbettinelli - Stored Procedure Universal SQL Database Access
// ------------------------------------------------------------------------------------------------------------------
// 06/15/2022 - This was converted from vb.net from my original copy form 800 yrs ago. 
//              Ref. - https://www.codeproject.com/Tips/654836/Good-Universal-Paramerter-and-Stored-Procedure-Exe
// ------------------------------------------------------------------------------------------------------------------
namespace WebPortfolio
{
    public class Com_DB
    {
        // ------------------------------------------------------------------------------------------------------------------
        // - GetConnectionIO() - Gets Sql Server Connection String.
        // ------------------------------------------------------------------------------------------------------------------
        private static string GetConnectionIO()
        {
            return "Data Source=" + Properties.Resources.SERVER + ";Initial Catalog=Pdb;User Id=" + Properties.Resources.username + ";Password=" + Properties.Resources.password + ";MultipleActiveResultSets=true;";
        }


        // ----------------------------------------------------------------------------------
        // - spg_UniversalPull - In/Out
        // ----------------------------------------------------------------------------------
        public static DataSet Spx_Uni(string sp)
        {
            List<string> v1 = new List<string>();
            List<object> v2 = new List<object>();

            return Spx_UniPull(sp, v1, v2, false);
        }


        // ----------------------------------------------------------------------------------
        // - spg_UniversalPull - In/Out
        // ----------------------------------------------------------------------------------
        public static DataSet Spx_Uni(string sp, List<string> v1, List<object> v2)
        {
            return Spx_UniPull(sp, v1, v2, false);
        }

        // ----------------------------------------------------------------------------------
        // - spg_UniversalPull Zero - In/Out
        // ----------------------------------------------------------------------------------
        public static DataSet Spx_UniZero(string sp, List<string> v1, List<object> v2)
        {
            return Spx_UniPull(sp, v1, v2, true);
        }


        // ----------------------------------------------------------------------------------
        // - spg_UniversalPull 
        // ----------------------------------------------------------------------------------
        public static DataSet Spx_UniPull(string sp, List<string> v1, List<object> v2, bool acceptZero)

        {
            SqlConnection dbConn; // = New SqlConnection
            SqlCommand dbCmd;
            SqlParameter dbPar;
            SqlDataAdapter dbAdp;
            DataSet dbDs = new DataSet()
            {
                Locale = CultureInfo.GetCultureInfo("en-US")
            };

            dbConn = new SqlConnection(GetConnectionIO());

            dbConn.Open();
            dbCmd = dbConn.CreateCommand();
            dbCmd.CommandText = sp;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandTimeout = 300;

            if (v1.Count > 0)
            {
                for (int x = 0; x <= v1.Count - 1; x++)
                {
                    object objct = v2[x];
                    string sel = objct.GetType().ToString();
                    dbPar = new SqlParameter()
                    {
                        ParameterName = "@" + v1[x],
                        Value = DBNull.Value
                    };
                    if (v2[x] != null)
                    {
                        switch (sel)
                        {
                            case "System.Boolean":
                                {
                                    dbPar.SqlDbType = SqlDbType.Bit;
                                    dbPar.Value = Convert.ToBoolean(v2[x]);
                                    break;
                                }

                            case "System.DateTime":
                            case "System.Date":
                                {

                                    dbPar.Value = v2[x];
                                    dbPar.SqlDbType = SqlDbType.DateTime;
                                    break;
                                }

                            case "System.Int32":
                                {
                                    if (acceptZero)
                                        dbPar.Value = Convert.ToInt32(v2[x]);
                                    else if (Convert.ToInt32(v2[x]) != 0)
                                        dbPar.Value = Convert.ToInt32(v2[x]);
                                    dbPar.SqlDbType = SqlDbType.Int;
                                    break;
                                }

                            case "System.Single":
                                {
                                    dbPar.Value = Convert.ToSingle(v1[x]);
                                    dbPar.SqlDbType = SqlDbType.Float;
                                    break;
                                }

                            case "System.Double":
                                {
                                    if (acceptZero)
                                        dbPar.Value = Convert.ToDouble(v2[x]);
                                    else if (Convert.ToInt32(v2[x]) != 0)
                                        dbPar.Value = Convert.ToDouble(v2[x]);
                                    dbPar.SqlDbType = SqlDbType.Float;
                                    break;
                                }

                            case "System.String":
                                {
                                    if (acceptZero)
                                        dbPar.Value = Convert.ToString(v2[x]);
                                    else if (System.Convert.ToString(v2[x]).Trim() != "")
                                        dbPar.Value = Convert.ToString(v2[x]);
                                    dbPar.SqlDbType = SqlDbType.NVarChar;
                                    break;
                                }
                        }
                        dbPar.Direction = ParameterDirection.Input;
                        dbCmd.Parameters.Add(dbPar);
                    }
                }
            }
            dbAdp = new SqlDataAdapter(dbCmd);
            dbAdp.Fill(dbDs);
            dbAdp.Dispose();
            dbConn.Close();
            return dbDs;

        }

    }
}