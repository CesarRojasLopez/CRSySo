using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL_WS_HMwhoEnters.BLL_CyM;
using DAL_WS_HMwhoEnters.DAL_CyM;

namespace WS_HMwhoEnters
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //patron factory y patron command
        //fabricas de invokers del patron comand
      //variacion el setCommand se realiza dentro del metodo invocado

        public DataSet Listar(string que_voy_a_listar)
        {
            DataTable dtResultado = null;
            
            DataSet ds = new DataSet();

            string msjError = string.Empty;
            
            switch ( que_voy_a_listar.ToUpper())
            {
                case "ACTIVIDADES":
                    cls_BLL_Actividades inv_actividades = new cls_BLL_Actividades();
                    dtResultado = inv_actividades.ListarActividades(ref msjError);//invoker
                    break;
                case "HORARIOS":
                    cls_BLL_HorariosVista inv_horarios = new cls_BLL_HorariosVista();
                    dtResultado = inv_horarios.ListarHorarios(ref msjError);
                    break;
                case "RESIDENTES":
                    cls_BLL_Residentes inv_residentes = new cls_BLL_Residentes();
                    dtResultado = inv_residentes.ListarResidentes(ref msjError);
                    break;
                case "TIPOVISITANTES":
                    cls_BLL_TipoVisitante inv_tipoVisitante = new cls_BLL_TipoVisitante();
                    dtResultado = inv_tipoVisitante.ListarTipoVisitante(ref msjError);
                    break;
                case "VISITANTES":
                    cls_BLL_Visitante inv_visitante = new cls_BLL_Visitante();
                    dtResultado = inv_visitante.ListarVisitante(ref msjError);
                    break;
                case "VISITAS":
                    cls_BLL_Visitas inv_visitas = new cls_BLL_Visitas();
                    dtResultado = inv_visitas.ListarVisitas(ref msjError);
                    break;
                case "USUARIOS":
                    cls_BLL_Usuarios inv_usuarios = new cls_BLL_Usuarios();
                    dtResultado = inv_usuarios.ListarUsuarios(ref msjError);
                    break;
                    
                default:
                    dtResultado = null;
                    break;
            }

            ds.Tables.Add(dtResultado.Copy());
            
            return ds;
        }

        public string Insertar(string que_voy_a_insertar, DataSet dtNombreValor)
        {
            string msj = string.Empty;

            switch (que_voy_a_insertar.ToUpper())
            {
                case "ACTIVIDADES":
                    cls_DAL_Actividades obj_DAL_actividades = new cls_DAL_Actividades();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "ESTADO":
                                    obj_DAL_actividades.ESTADO = Convert.ToChar(item[1].ToString());
                                    break;
                                case "NOMBRE_ACTIVIDAD":
                                    obj_DAL_actividades.NOMBRE_ACTIVIDAD = item[1].ToString();
                                    break;
                                case "USUARIO_CREACION":
                                    obj_DAL_actividades.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_Actividades inv_actividades = new cls_BLL_Actividades();
                    inv_actividades.InsertarActividades(ref msj, ref obj_DAL_actividades);
                    msj = "Operación exitosa";
                    if (msj==string.Empty || msj=="")
                    {
                        msj = "Operación exitosa";
                    }
                    break;

                case "HORARIOS":
                    cls_DAL_Horarios_Visita obj_dal_horarios = new cls_DAL_Horarios_Visita();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "DESCRIPCION":
                                    obj_dal_horarios.DESCRIPCION =item[1].ToString();
                                    break;
                                case "DIA_SEMANA":
                                    obj_dal_horarios.DIA_SEMANA = item[1].ToString();
                                    break;                           
                                case "H_INICIO":
                                    obj_dal_horarios.H_INICIO = Convert.ToDateTime(item[1].ToString());
                                    break;
                                case "H_FIN":
                                    obj_dal_horarios.H_FIN = Convert.ToDateTime(item[1].ToString());
                                    break;
                                case "USUARIO_CREACION":
                                    obj_dal_horarios.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;
                                case "ESTADO":
                                    obj_dal_horarios.ESTADO = Convert.ToChar(item[1].ToString());
                                    break;
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_HorariosVista inv_horarios = new cls_BLL_HorariosVista();
                    inv_horarios.InsertarHorarios(ref msj, ref obj_dal_horarios);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "RESIDENTES":
                    cls_DAL_Residentes obj_dal_residentes = new cls_DAL_Residentes();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "CEDULA":
                                    obj_dal_residentes.CEDULA = item[1].ToString();
                                    break;
                                case "NOMBRE":
                                    obj_dal_residentes.NOMBRE = item[1].ToString();
                                    break;
                                case "APELLIDOS":
                                    obj_dal_residentes.APELLIDOS = item[1].ToString();
                                    break;
                                case "GENERO":
                                    obj_dal_residentes.GENERO = item[1].ToString();
                                    break;
                                case "NOMBRE_CONTACTO":
                                    obj_dal_residentes.NOMBRE_CONTACTO = item[1].ToString();
                                    break;
                                case "TEL_CONTACTO":
                                    obj_dal_residentes.TEL_CONTACTO = item[1].ToString();
                                    break;
                                case "CORREO_CONTACTO":
                                    obj_dal_residentes.CORREO_CONTACTO = item[1].ToString();
                                    break;
                                case "FECHA_INGRESO":
                                    obj_dal_residentes.FECHA_INGRESO = Convert.ToDateTime(item[1].ToString());
                                    break;
                                case "FECHA_ULT_VISITA":
                                    obj_dal_residentes.FECHA_ULT_VISITA = Convert.ToDateTime(item[1].ToString());
                                    break;
                                case "USUARIO_CREACION":
                                    obj_dal_residentes.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;
                                case "ESTADO":
                                    obj_dal_residentes.ESTADO = Convert.ToChar(item[1].ToString());
                                    break;
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_Residentes inv_residentes = new cls_BLL_Residentes();
                    inv_residentes.InsertarResidentes(ref msj, ref obj_dal_residentes);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "TIPOVISITANTES":
                    cls_DAL_TipoVisitante obj_dal_tipoVisitante = new cls_DAL_TipoVisitante();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "DESCRIPCION":
                                    obj_dal_tipoVisitante.DESCRIPCION = item[1].ToString();
                                    break;
                                case "DETALLE":
                                    obj_dal_tipoVisitante.DETALLE = item[1].ToString();
                                    break;
                                case "NOMENCLATURA":
                                     obj_dal_tipoVisitante.NOMENCLATURA = item[1].ToString();
                                    break;
                                case "ESTADO":
                                     obj_dal_tipoVisitante.ESTADO = Convert.ToChar(item[1].ToString());
                                    break;
                                case "USUARIO_CREACION":
                                    obj_dal_tipoVisitante.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;                             
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_TipoVisitante inv_tipoVisitante = new cls_BLL_TipoVisitante();
                    inv_tipoVisitante.InsertarTipoVisitante(ref msj, ref obj_dal_tipoVisitante);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITANTES":
                    cls_DAL_Visitante obj_dal_visitante = new cls_DAL_Visitante();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "CEDULA":
                                    obj_dal_visitante.CEDULA = item[1].ToString();
                                    break;
                                case "NOMBRE":
                                    obj_dal_visitante.NOMBRE = item[1].ToString();
                                    break;
                                case "APELLIDOS":
                                    obj_dal_visitante.APELLIDOS = item[1].ToString();
                                    break;
                                case "GENERO":
                                    obj_dal_visitante.GENERO = item[1].ToString();
                                    break;
                                case "TEL_VISITANTE":
                                    obj_dal_visitante.TEL_VISITANTE = item[1].ToString();
                                    break;
                                case "CORREO":
                                    obj_dal_visitante.CORREO = item[1].ToString();
                                    break;
                                case "CED_ULT_VISITADO":
                                    obj_dal_visitante.CED_ULT_VISITADO = item[1].ToString();
                                    break;
                                case "ID_TIPO_VISITANTE":
                                    obj_dal_visitante.ID_TIPO_VISITANTE = Convert.ToUInt16(item[1].ToString());
                                    break;
                                case "USUARIO_CREACION":
                                    obj_dal_visitante.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;
                                case "ESTADO":
                                    obj_dal_visitante.ESTADO = Convert.ToChar(item[1].ToString());
                                    break;
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_Visitante inv_visitante = new cls_BLL_Visitante();
                    inv_visitante.InsertarVisitante(ref msj, ref obj_dal_visitante);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITAS":
                    cls_DAL_Visitas obj_dal_visitas = new cls_DAL_Visitas();
                        foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                        {
                            switch (item[0].ToString().ToUpper())
                            {
                                case "CEDULA_VISITANTE":
                                obj_dal_visitas.CEDULA_VISITANTE = item[1].ToString();
                                    break;
                                case "CEDULA_RESIDENTE":
                                obj_dal_visitas.CEDULA_RESIDENTE = item[1].ToString();
                                    break;                               
                                case "TIPO_VISITANTE":
                                obj_dal_visitas.TIPO_VISITANTE = Convert.ToInt16( item[1].ToString());
                                    break;
                                case "ID_ACTIVIDAD":
                                obj_dal_visitas.ID_ACTIVIDAD = Convert.ToInt16( item[1].ToString());
                                    break;
                                case "ID_HORARIO_VISITADO":
                                obj_dal_visitas.ID_HORARIO_VISITADO = Convert.ToInt16( item[1].ToString());
                                    break;
                                case "USUARIO_CREACION":
                                obj_dal_visitas.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                    break;
                                default:
                                msj = "información incompleta";
                                break;
                            }
                        }
                    cls_BLL_Visitas inv_visitas = new cls_BLL_Visitas();
                    inv_visitas.InsertarVisitas(ref msj, ref obj_dal_visitas);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "USUARIOS":
                    csl_DAL_Usuarios obj_dal_usuarios = new csl_DAL_Usuarios();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "USUARIO":
                                obj_dal_usuarios.USUARIO = item[1].ToString();
                                break;
                            case "PASWORD":
                                obj_dal_usuarios.PASWORD = item[1].ToString();
                                break;
                            case "ESTADO":
                                obj_dal_usuarios.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            case "ROL":
                                obj_dal_usuarios.ROL = item[1].ToString();
                                break;
                            case "USUARIO_CREACION":
                                obj_dal_usuarios.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Usuarios inv_usuarios = new cls_BLL_Usuarios();
                    inv_usuarios.InsertarUsuarios(ref msj, ref obj_dal_usuarios);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;

                default:
                    msj ="instruccion no encontrada";
                    break;
            }
            
            return msj;
        }

        public string Modificar(string que_voy_a_modificar, DataSet dtNombreValor)
        {
            string msj = string.Empty;

            switch (que_voy_a_modificar.ToUpper())
            {
                case "ACTIVIDADES":
                    cls_DAL_Actividades obj_DAL_actividades = new cls_DAL_Actividades();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "ID_ACTIVIDAD":
                                obj_DAL_actividades.ID_ACTIVIDAD = Convert.ToInt16(item[1].ToString());
                                break;
                            case "NOMBRE_ACTIVIDAD":
                                obj_DAL_actividades.NOMBRE_ACTIVIDAD = item[1].ToString();
                                break;
                            case "ESTADO":
                                obj_DAL_actividades.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Actividades inv_actividades = new cls_BLL_Actividades();
                    inv_actividades.ModificarActividades(ref msj, ref obj_DAL_actividades);
                    msj = "Operación exitosa";
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;

                case "HORARIOS":
                    cls_DAL_Horarios_Visita obj_dal_horarios = new cls_DAL_Horarios_Visita();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "ID_HORARIO":
                                obj_dal_horarios.ID_HORARIO = Convert.ToInt16(item[1].ToString());
                                break;
                            case "DESCRIPCION":
                                obj_dal_horarios.DESCRIPCION = item[1].ToString();
                                break;
                            case "DIA_SEMANA":
                                obj_dal_horarios.DIA_SEMANA = item[1].ToString();
                                break;
                            case "H_INICIO":
                                obj_dal_horarios.H_INICIO = Convert.ToDateTime(item[1].ToString());
                                break;
                            case "H_FIN":
                                obj_dal_horarios.H_FIN = Convert.ToDateTime(item[1].ToString());
                                break;          
                            case "ESTADO":
                                obj_dal_horarios.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_HorariosVista inv_horarios = new cls_BLL_HorariosVista();
                    inv_horarios.ModificaHorarios(ref msj, ref obj_dal_horarios);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "RESIDENTES":
                    cls_DAL_Residentes obj_dal_residentes = new cls_DAL_Residentes();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "CEDULA":
                                obj_dal_residentes.CEDULA = item[1].ToString();
                                break;
                            case "NOMBRE":
                                obj_dal_residentes.NOMBRE = item[1].ToString();
                                break;
                            case "APELLIDOS":
                                obj_dal_residentes.APELLIDOS = item[1].ToString();
                                break;
                            case "GENERO":
                                obj_dal_residentes.GENERO = item[1].ToString();
                                break;
                            case "NOMBRE_CONTACTO":
                                obj_dal_residentes.NOMBRE_CONTACTO = item[1].ToString();
                                break;
                            case "TEL_CONTACTO":
                                obj_dal_residentes.TEL_CONTACTO = item[1].ToString();
                                break;
                            case "CORREO_CONTACTO":
                                obj_dal_residentes.CORREO_CONTACTO = item[1].ToString();
                                break;                            
                            case "FECHA_ULT_VISITA":
                                obj_dal_residentes.FECHA_ULT_VISITA = Convert.ToDateTime(item[1].ToString());
                                break;                            
                            case "ESTADO":
                                obj_dal_residentes.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Residentes inv_residentes = new cls_BLL_Residentes();
                    inv_residentes.ModificarResidentes(ref msj, ref obj_dal_residentes);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "TIPOVISITANTES":
                    cls_DAL_TipoVisitante obj_dal_tipoVisitante = new cls_DAL_TipoVisitante();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "ID_TIPO_VISITANTE":
                                obj_dal_tipoVisitante.USUARIO_CREACION = Convert.ToInt16(item[1].ToString());
                                break;
                            case "DESCRIPCION":
                                obj_dal_tipoVisitante.DESCRIPCION = item[1].ToString();
                                break;
                            case "DETALLE":
                                obj_dal_tipoVisitante.DETALLE = item[1].ToString();
                                break;
                            case "NOMENCLATURA":
                                obj_dal_tipoVisitante.NOMENCLATURA = item[1].ToString();
                                break;
                            case "ESTADO":
                                obj_dal_tipoVisitante.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_TipoVisitante inv_tipoVisitante = new cls_BLL_TipoVisitante();
                    inv_tipoVisitante.ModificarTipoVisitante(ref msj, ref obj_dal_tipoVisitante);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITANTES":
                    cls_DAL_Visitante obj_dal_visitante = new cls_DAL_Visitante();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "CEDULA":
                                obj_dal_visitante.CEDULA = item[1].ToString();
                                break;
                            case "NOMBRE":
                                obj_dal_visitante.NOMBRE = item[1].ToString();
                                break;
                            case "APELLIDOS":
                                obj_dal_visitante.APELLIDOS = item[1].ToString();
                                break;
                            case "GENERO":
                                obj_dal_visitante.GENERO = item[1].ToString();
                                break;
                            case "TEL_VISITANTE":
                                obj_dal_visitante.TEL_VISITANTE = item[1].ToString();
                                break;
                            case "CORREO":
                                obj_dal_visitante.CORREO = item[1].ToString();
                                break;
                            case "CED_ULT_VISITADO":
                                obj_dal_visitante.CED_ULT_VISITADO = item[1].ToString();
                                break;
                            case "ID_TIPO_VISITANTE":
                                obj_dal_visitante.ID_TIPO_VISITANTE = Convert.ToUInt16(item[1].ToString());
                                break;                            
                            case "ESTADO":
                                obj_dal_visitante.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Visitante inv_visitante = new cls_BLL_Visitante();
                    inv_visitante.ModificarVisitante(ref msj, ref obj_dal_visitante);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITAS":
                    cls_DAL_Visitas obj_dal_visitas = new cls_DAL_Visitas();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "ID_VISITA":
                                obj_dal_visitas.CEDULA_VISITANTE = item[1].ToString();
                                break;
                            case "CEDULA_VISITANTE":
                                obj_dal_visitas.CEDULA_VISITANTE = item[1].ToString();
                                break;
                            case "CEDULA_RESIDENTE":
                                obj_dal_visitas.CEDULA_RESIDENTE = item[1].ToString();
                                break;
                            case "TIPO_VISITANTE":
                                obj_dal_visitas.TIPO_VISITANTE = Convert.ToInt16(item[1].ToString());
                                break;
                            case "ID_ACTIVIDAD":
                                obj_dal_visitas.ID_ACTIVIDAD = Convert.ToInt16(item[1].ToString());
                                break;
                            case "ID_HORARIO_VISITADO":
                                obj_dal_visitas.ID_HORARIO_VISITADO = Convert.ToInt16(item[1].ToString());
                                break;
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Visitas inv_visitas = new cls_BLL_Visitas();
                    inv_visitas.ModificarVisitas(ref msj, ref obj_dal_visitas);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "USUARIOS":
                    csl_DAL_Usuarios obj_dal_usuarios = new csl_DAL_Usuarios();
                    foreach (DataRow item in dtNombreValor.Tables[0].Rows)
                    {
                        switch (item[0].ToString().ToUpper())
                        {
                            case "ID_USUARIO":
                                obj_dal_usuarios.ID_USUARIO = Convert.ToInt16(item[1].ToString());
                                break;
                            case "USUARIO":
                                obj_dal_usuarios.USUARIO = item[1].ToString();
                                break;
                            case "PASWORD":
                                obj_dal_usuarios.PASWORD = item[1].ToString();
                                break;
                            case "ESTADO":
                                obj_dal_usuarios.ESTADO = Convert.ToChar(item[1].ToString());
                                break;
                            case "ROL":
                                obj_dal_usuarios.ROL = item[1].ToString();
                                break;
                            
                            default:
                                msj = "información incompleta";
                                break;
                        }
                    }
                    cls_BLL_Usuarios inv_usuarios = new cls_BLL_Usuarios();
                    inv_usuarios.ModificarUsuarios(ref msj, ref obj_dal_usuarios);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;

                default:
                    msj = "instruccion no encontrada";
                    break;
            }

            return msj;
        }

        public string Eliminar(string que_voy_a_eliminar, string id_eliminar)
        {
            string msj = string.Empty;

            switch (que_voy_a_eliminar.ToUpper())
            {
                case "ACTIVIDADES":                    
                    cls_BLL_Actividades inv_actividades = new cls_BLL_Actividades();
                    inv_actividades.EliminarActividades(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "HORARIOS":
                    cls_BLL_HorariosVista inv_horarios = new cls_BLL_HorariosVista();
                    inv_horarios.EliminarHorarios(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    };
                    break;
                case "RESIDENTES":
                    cls_BLL_Residentes inv_residentes = new cls_BLL_Residentes();
                    inv_residentes.EliminarResidentes(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "TIPOVISITANTES":
                    cls_BLL_TipoVisitante inv_tipoVisitante = new cls_BLL_TipoVisitante();
                    inv_tipoVisitante.EliminarTipoVisitante(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITANTES":
                    cls_BLL_Visitante inv_visitante = new cls_BLL_Visitante();
                    inv_visitante.EliminarVisitante(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "VISITAS":
                    cls_BLL_Visitas inv_visitas = new cls_BLL_Visitas();
                    inv_visitas.EliminarVisitas(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;
                case "USUARIOS":
                    cls_BLL_Usuarios inv_usuarios = new cls_BLL_Usuarios();
                    inv_usuarios.EliminarUsuarios(ref msj, id_eliminar);
                    if (msj == string.Empty || msj == "")
                    {
                        msj = "Operación exitosa";
                    }
                    break;

                default:
                    msj = "instruccion no encontrada";
                    break;
            }

            return msj;
        }
        



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
