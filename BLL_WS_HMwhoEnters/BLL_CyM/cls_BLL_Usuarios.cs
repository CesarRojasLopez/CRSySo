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
    public class cls_BLL_Usuarios
    {
        public DataTable ListarUsuarios(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de Usuarios";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_USUARIOS"];
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

        public DataTable FiltrarUsuarios(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de Usuarios";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO", 2, sFiltro);
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

        public void InsertarUsuarios(ref string sMsjError, ref csl_DAL_Usuarios Obj_DAL_Usuarios)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Usuarios.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_CREACION", 6, Obj_DAL_Usuarios.FECHA_CREACION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_USUARIO", 3, Obj_DAL_Usuarios.ID_USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@PASWORD", 2, Obj_DAL_Usuarios.ID_USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ROL", 2, Obj_DAL_Usuarios.ROL.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO", 2, Obj_DAL_Usuarios.USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 1, Obj_DAL_Usuarios.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_USUARIOS"];

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

        public void ModificarUsuarios(ref string sMsjError, ref csl_DAL_Usuarios Obj_DAL_Usuarios)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Usuarios.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_CREACION", 6, Obj_DAL_Usuarios.FECHA_CREACION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_USUARIO", 3, Obj_DAL_Usuarios.ID_USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@PASWORD", 2, Obj_DAL_Usuarios.ID_USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ROL", 2, Obj_DAL_Usuarios.ROL.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO", 2, Obj_DAL_Usuarios.USUARIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 1, Obj_DAL_Usuarios.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_USUARIOS"];

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

        public void EliminarUsuarios(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_USUARIOS"];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_USUARIO", 3, sFiltro);

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
