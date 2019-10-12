using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL_WS_HMwhoEnters.DAL_DB;
using System.Configuration;

namespace BLL_WS_HMwhoEnters.BLL_DB
{
    public class cls_BLL_DB
    {
        public void CrearDTParametros(ref cls_DAL_DB Obj_DAL_DB)
        {

            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipo = new DataColumn(@"Tip_Dato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL_DB.dt_Parametros.Columns.Add(dcNombre);
            Obj_DAL_DB.dt_Parametros.Columns.Add(dcTipo);
            Obj_DAL_DB.dt_Parametros.Columns.Add(dcValor);
        }

        public void TraerConexion(ref cls_DAL_DB Obj_DAL_DB)
        {
            try
            {
                Obj_DAL_DB.sCadena = ConfigurationManager.ConnectionStrings["CNX_SQL_CALLCENTER"].ToString().Trim();
                Obj_DAL_DB.sql_CNX = new SqlConnection(Obj_DAL_DB.sCadena);
            }
            catch (Exception e)
            {
                Obj_DAL_DB.sMsgError = e.Message;
                Obj_DAL_DB.sCadena = string.Empty;
                Obj_DAL_DB.sql_CNX = null;
            }
        }

        public void Ejec_DataAdap(ref cls_DAL_DB Obj_DAL_DB)
        {
            try
            {
                TraerConexion(ref Obj_DAL_DB);
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_DB.sql_CNX.Open();
                        Obj_DAL_DB.sql_DA = new SqlDataAdapter(Obj_DAL_DB.sSentencia, Obj_DAL_DB.sql_CNX);
                        Obj_DAL_DB.sql_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_DB.dt_Parametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_DB.dt_Parametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.Date;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_DB.sql_DA.SelectCommand.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_DB.DS = new DataSet();
                        Obj_DAL_DB.sql_DA.Fill(Obj_DAL_DB.DS, Obj_DAL_DB.sNombreTabla);
                        Obj_DAL_DB.sMsgError = string.Empty;
                    }
                }
            }
            catch (SqlException e)
            {
                Obj_DAL_DB.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_DB.sql_CNX.Close();
                        Obj_DAL_DB.sql_CNX.Dispose();
                    }
                }
            }
        }

        public void Ejec_NonQuery(ref cls_DAL_DB Obj_DAL_DB)
        {
            try
            {
                TraerConexion(ref Obj_DAL_DB);
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_DB.sql_CNX.Open();
                        Obj_DAL_DB.sql_Cmd = new SqlCommand(Obj_DAL_DB.sSentencia, Obj_DAL_DB.sql_CNX);
                        Obj_DAL_DB.sql_Cmd.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_DB.dt_Parametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_DB.dt_Parametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_DB.sql_Cmd.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_DB.sql_Cmd.ExecuteNonQuery();
                        Obj_DAL_DB.sMsgError = string.Empty;
                    }
                }

            }
            catch (SqlException e)
            {
                Obj_DAL_DB.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_DB.sql_CNX.Close();
                    }
                    Obj_DAL_DB.sql_CNX.Dispose();
                }
            }
        }

        public void Ejec_Scalar(ref cls_DAL_DB Obj_DAL_DB)
        {
            try
            {
                TraerConexion(ref Obj_DAL_DB);
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_DB.sql_CNX.Open();
                        Obj_DAL_DB.sql_Cmd = new SqlCommand(Obj_DAL_DB.sSentencia, Obj_DAL_DB.sql_CNX);
                        Obj_DAL_DB.sql_Cmd.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_DB.dt_Parametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_DB.dt_Parametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_DB.sql_Cmd.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_DB.iValorScalar = Convert.ToInt32(Obj_DAL_DB.sql_Cmd.ExecuteScalar());
                        Obj_DAL_DB.sMsgError = string.Empty;
                    }
                }

            }
            catch (SqlException e)
            {
                Obj_DAL_DB.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_DB.sql_CNX != null)
                {
                    if (Obj_DAL_DB.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_DB.sql_CNX.Close();
                    }
                    Obj_DAL_DB.sql_CNX.Dispose();
                }
            }
        }
    }
}
