using BLL_WS_HMwhoEnters.BLL_DB;
using DAL_WS_HMwhoEnters.DAL_CyM;
using DAL_WS_HMwhoEnters.DAL_DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_WS_HMwhoEnters.BLL_CyM
{
    public class cls_BLL_Residentes
    {
        public DataTable ListarHorarios(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de Residentes";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_RESIDENTES"];
            ObjBllCNX.Ejec_DataAdap(ref ObjDalDB);

            if (ObjDalDB.sMsgError != string.Empty)
            {
                sMsjError = ObjDalDB.sMsgError;
                return null;
            }
            else
            {
                sMsjError = string.Empty;
                return ObjDalDB.DS.Tables[0];
            }
        }

        public DataTable FiltrarActividades(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de Horarios";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 3, sFiltro);
            ObjBllCNX.Ejec_DataAdap(ref ObjDalDB);

            if (ObjDalDB.sMsgError != string.Empty)
            {
                sMsjError = ObjDalDB.sMsgError;
                return null;
            }
            else
            {
                sMsjError = string.Empty;
                return ObjDalDB.DS.Tables[0];
            }
        }

        public void InsertarActividades(ref string sMsjError, ref cls_DAL_Residentes Obj_DAL_Residentes)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@APELLIDOS", 2, Obj_DAL_Residentes.APELLIDOS.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 2, Obj_DAL_Residentes.CEDULA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CORREO_CONTACTO", 2, Obj_DAL_Residentes.CORREO_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Residentes.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_CREACION", 6, Obj_DAL_Residentes.FECHA_CREACION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_INGRESO", 6, Obj_DAL_Residentes.FECHA_INGRESO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_ULT_VISITA", 6, Obj_DAL_Residentes.FECHA_ULT_VISITA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@GENERO", 2, Obj_DAL_Residentes.GENERO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE", 2, Obj_DAL_Residentes.NOMBRE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE_CONTACTO", 2, Obj_DAL_Residentes.NOMBRE_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@TEL_CONTACTO", 2, Obj_DAL_Residentes.TEL_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 3, Obj_DAL_Residentes.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_RESIDENTES"];

            ObjBllCNX.Ejec_Scalar(ref ObjDalDB);

            if (ObjDalDB.sMsgError != string.Empty)
            {
                sMsjError = ObjDalDB.sMsgError;
            }
            else
            {
                sMsjError = string.Empty;
            }
        }

        public void ModificarActividades(ref string sMsjError, ref cls_DAL_Residentes Obj_DAL_Residentes)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@APELLIDOS", 2, Obj_DAL_Residentes.APELLIDOS.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 2, Obj_DAL_Residentes.CEDULA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CORREO_CONTACTO", 2, Obj_DAL_Residentes.CORREO_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Residentes.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_CREACION", 6, Obj_DAL_Residentes.FECHA_CREACION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_INGRESO", 6, Obj_DAL_Residentes.FECHA_INGRESO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_ULT_VISITA", 6, Obj_DAL_Residentes.FECHA_ULT_VISITA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@GENERO", 2, Obj_DAL_Residentes.GENERO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE", 2, Obj_DAL_Residentes.NOMBRE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE_CONTACTO", 2, Obj_DAL_Residentes.NOMBRE_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@TEL_CONTACTO", 2, Obj_DAL_Residentes.TEL_CONTACTO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 3, Obj_DAL_Residentes.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_RESIDENTES"];

            ObjBllCNX.Ejec_NonQuery(ref ObjDalDB);

            if (ObjDalDB.sMsgError != string.Empty)
            {
                sMsjError = ObjDalDB.sMsgError;
            }
            else
            {
                sMsjError = string.Empty;
            }
        }

        public void EliminarActividades(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_RESIDENTES"];
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 3, sFiltro);

            ObjBllCNX.Ejec_NonQuery(ref ObjDalDB);

            if (ObjDalDB.sMsgError != string.Empty)
            {
                sMsjError = ObjDalDB.sMsgError;
            }
            else
            {
                sMsjError = string.Empty;
            }
        }
    }
}
