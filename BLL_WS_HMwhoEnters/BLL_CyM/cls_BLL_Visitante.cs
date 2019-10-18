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
    public class cls_BLL_Visitante
    {
        public DataTable ListarVisitante(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de Visitantes";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_VISITANTES"];
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

        public DataTable FiltrarVisitantes(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de Visitantes";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@DESCRIPCION", 2, sFiltro);
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

        public void InsertarVisitante(ref string sMsjError, ref cls_DAL_Visitante Obj_DAL_Visitante)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

                ObjDalDB.dt_Parametros.Rows.Add("@APELLIDOS", 2, Obj_DAL_Visitante.APELLIDOS.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@CED_ULT_VISITADO", 2, Obj_DAL_Visitante.CED_ULT_VISITADO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 2, Obj_DAL_Visitante.CEDULA.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@CORREO", 2, Obj_DAL_Visitante.CORREO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Visitante.ESTADO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@GENERO", 2, Obj_DAL_Visitante.GENERO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE", 2, Obj_DAL_Visitante.NOMBRE.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@TEL_VISITANTE", 2, Obj_DAL_Visitante.TEL_VISITANTE.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 3, Obj_DAL_Visitante.USUARIO_CREACION.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@ID_TIPO_VISITANTE", 3, Obj_DAL_Visitante.USUARIO_CREACION.ToString().Trim());


            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_VISITANTES"];

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

        public void ModificarVisitante(ref string sMsjError, ref cls_DAL_Visitante Obj_DAL_Visitante)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@APELLIDOS", 2, Obj_DAL_Visitante.APELLIDOS.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CED_ULT_VISITADO", 2, Obj_DAL_Visitante.CED_ULT_VISITADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA", 2, Obj_DAL_Visitante.CEDULA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CORREO", 2, Obj_DAL_Visitante.CORREO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Visitante.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@GENERO", 2, Obj_DAL_Visitante.GENERO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_TIPO_VISITANTE", 3, Obj_DAL_Visitante.ID_TIPO_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMBRE", 2, Obj_DAL_Visitante.NOMBRE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@TEL_VISITANTE", 2, Obj_DAL_Visitante.TEL_VISITANTE.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_VISITANTES"];

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

        public void EliminarVisitante(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_VISITANTES"];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_TIPO_VISITANTE", 3, sFiltro);

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
