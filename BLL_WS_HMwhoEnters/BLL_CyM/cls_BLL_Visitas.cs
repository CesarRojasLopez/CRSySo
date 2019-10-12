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
    public class cls_BLL_Visitas
    {
        public DataTable ListarVisitas(ref string sMsjError)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB  ObjDalDB = new cls_DAL_DB();
            ObjDalDB.sNombreTabla = "Lista de Activos";
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["SP_Listar_Activos"];
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

        public DataTable FiltrarVisitas(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();
            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sNombreTabla = "Lista de Activos";
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["SP_Filtrar_Activos"];
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

        public void InsertarVisitas(ref string sMsjError, ref cls_DAL_Visitas Obj_DAL_Visitas)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA_RESIDENTE", 3, Obj_DAL_Visitas.CEDULA_RESIDENTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA_VISITANTE", 1,  Obj_DAL_Visitas.CEDULA_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_HORA_INGRESO", 3, Obj_DAL_Visitas.FECHA_HORA_INGRESO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_HORA_SALIDA", 3, Obj_DAL_Visitas.FECHA_HORA_SALIDA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_ACTIVIDAD", 5, Obj_DAL_Visitas.ID_ACTIVIDAD.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_HORARIO_VISITADO", 2, Obj_DAL_Visitas.ID_HORARIO_VISITADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_VISITA", 4, Obj_DAL_Visitas.ID_VISITA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@TIPO_VISITANTE", 1, Obj_DAL_Visitas.TIPO_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 4, Obj_DAL_Visitas.USUARIO_CREACION.ToString().Trim());


        ObjDalDB.sSentencia = ConfigurationManager.AppSettings["Insertar_Activos"];

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
      
        public void ModificarVisitas(ref string sMsjError, ref cls_DAL_Visitas Obj_DAL_Visitas)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);

            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA_RESIDENTE", 3, Obj_DAL_Visitas.CEDULA_RESIDENTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@CEDULA_VISITANTE", 1, Obj_DAL_Visitas.CEDULA_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_HORA_INGRESO", 3, Obj_DAL_Visitas.FECHA_HORA_INGRESO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@FECHA_HORA_SALIDA", 3, Obj_DAL_Visitas.FECHA_HORA_SALIDA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_ACTIVIDAD", 5, Obj_DAL_Visitas.ID_ACTIVIDAD.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_HORARIO_VISITADO", 2, Obj_DAL_Visitas.ID_HORARIO_VISITADO.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@ID_VISITA", 4, Obj_DAL_Visitas.ID_VISITA.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@TIPO_VISITANTE", 1, Obj_DAL_Visitas.TIPO_VISITANTE.ToString().Trim());
            ObjDalDB.dt_Parametros.Rows.Add("@USUARIO_CREACION", 4, Obj_DAL_Visitas.USUARIO_CREACION.ToString().Trim());


            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["Modificar_Activos"];

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

        public void EliminarVisitas(ref string sMsjError, string sFiltro)
        {
            cls_BLL_DB ObjBllCNX = new cls_BLL_DB();
            cls_DAL_DB ObjDalDB = new cls_DAL_DB();

            ObjBllCNX.CrearDTParametros(ref ObjDalDB);
            ObjDalDB.sSentencia = ConfigurationManager.AppSettings["SP_Eliminar_Activos"];
            ObjDalDB.dt_Parametros.Rows.Add("@Placa_Activo", 3, sFiltro);

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
