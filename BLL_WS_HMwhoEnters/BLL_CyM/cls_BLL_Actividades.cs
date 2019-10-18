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
    public class cls_BLL_Actividades
    {
        public DataTable ListarActividades(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de actividades";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_ACTIVIDADES"];//este es el set command, en epañol aqui le setiamos el comando a ejecutar
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
            ObjDalDB.sNombreTabla = "Lista de Activos";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@Desc_Activo", 1, sFiltro);
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

        public void InsertarActividades(ref string sMsjError, ref cls_DAL_Actividades Obj_DAL_Actividades)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Actividades.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE_ACTIVIDAD", 3, Obj_DAL_Actividades.NOMBRE_ACTIVIDAD.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 3, Obj_DAL_Actividades.USUARIO_CREACION.ToString().Trim());            
            
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_ACTIVIDADES"];

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

        public void ModificarActividades(ref string sMsjError, ref cls_DAL_Actividades Obj_DAL_Actividades)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Actividades.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_ACTIVIDAD", 3, Obj_DAL_Actividades.ID_ACTIVIDAD.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE_ACTIVIDAD", 3, Obj_DAL_Actividades.NOMBRE_ACTIVIDAD.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_ACTIVIDADES"];

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
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_ACTIVIDADES"];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_ACTIVIDAD", 3, sFiltro);

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
