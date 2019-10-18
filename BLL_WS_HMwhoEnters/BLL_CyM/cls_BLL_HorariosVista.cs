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
    public class cls_BLL_HorariosVista
    {
        public DataTable ListarHorarios(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de Horarios";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["LISTAR_HORARIOS"];
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

        public DataTable FiltrarHorarios(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de Horarios";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings[""];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_HORARIO", 3, sFiltro);
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

        public void InsertarHorarios(ref string sMsjError, ref cls_DAL_Horarios_Visita Obj_DAL_Horarios)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@DESCRIPCION", 1, Obj_DAL_Horarios.DESCRIPCION.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@DIA_SEMANA", 6, Obj_DAL_Horarios.DIA_SEMANA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Horarios.ESTADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@H_FIN", 3, Obj_DAL_Horarios.H_FIN.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@H_INICIO", 3, Obj_DAL_Horarios.H_INICIO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 3, Obj_DAL_Horarios.USUARIO_CREACION.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["INSERTAR_HORARIOS"];

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

        public void ModificaHorarios(ref string sMsjError, ref cls_DAL_Horarios_Visita Obj_DAL_Horarios)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

                ObjDalDB.dt_Parametros.Rows.Add("@DESCRIPCION", 1, Obj_DAL_Horarios.DESCRIPCION.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@DIA_SEMANA", 6, Obj_DAL_Horarios.DIA_SEMANA.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@ESTADO", 1, Obj_DAL_Horarios.ESTADO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@H_FIN", 3, Obj_DAL_Horarios.H_FIN.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@H_INICIO", 3, Obj_DAL_Horarios.H_INICIO.ToString().Trim());
                ObjDalDB.dt_Parametros.Rows.Add("@ID_HORARIO", 3, Obj_DAL_Horarios.ID_HORARIO.ToString().Trim());

            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["MODIFICAR_HORARIOS"];

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

        public void EliminarHorarios(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["ELIMINAR_HORARIOS"];
            ObjDalDB.dt_Parametros.Rows.Add("@ID_HORARIO", 3, sFiltro);

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
