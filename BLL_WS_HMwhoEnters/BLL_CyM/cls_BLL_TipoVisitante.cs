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
    public class cls_BLL_TipoVisitante
    {
        public DataTable ListarTipoVisitante(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de TipoVisitante";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_TIPO_VISITANTE"];
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

        public DataTable FiltrarTipoVisitante(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de TipoVisitante";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_TIPO_VISITANTE", 3, sFiltro);
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

        public void InsertarTipoVisitante(ref string sMsjError, ref cls_DAL_TipoVisitante Obj_DAL_TipoVisitante)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@DESCRIPCION", 2, Obj_DAL_TipoVisitante.DESCRIPCION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@DETALLE", 2, Obj_DAL_TipoVisitante.DETALLE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_TipoVisitante.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMENCLATURA", 2, Obj_DAL_TipoVisitante.NOMENCLATURA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 1, Obj_DAL_TipoVisitante.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_TIPO_VISITANTE"];

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

        public void ModificarTipoVisitante(ref string sMsjError, ref cls_DAL_TipoVisitante Obj_DAL_TipoVisitante)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@DESCRIPCION", 2, Obj_DAL_TipoVisitante.DESCRIPCION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@DETALLE", 2, Obj_DAL_TipoVisitante.DETALLE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_TipoVisitante.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_TIPO_VISITANTE", 3, Obj_DAL_TipoVisitante.ID_TIPO_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@NOMENCLATURA", 2, Obj_DAL_TipoVisitante.NOMENCLATURA.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_TIPO_VISITANTE"];

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

        public void EliminarTipoVisitante(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_TIPO_VISITANTE"];
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
