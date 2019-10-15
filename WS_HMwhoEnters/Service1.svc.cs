using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL_WS_HMwhoEnters.BLL_CyM;

namespace WS_HMwhoEnters
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //patron factory y patron command
        //fabricas de invokers del patron comand
      //variacion el setCommand se realiza dentro del metodo invocado

            public DataTable Listar(string que_voy_a_listar)
        {
            DataTable dtResultado = null;
            string msjError = string.Empty;
            
            switch ( que_voy_a_listar.ToUpper())
            {
                case "ACTIVIDADES":
                    cls_BLL_Actividades inv_actividades = new cls_BLL_Actividades();
                    dtResultado = inv_actividades.ListarActividades(ref msjError);//invoker
                    break;
                case "HORARIOS":

                    break;
                case "RESIDENTES":
                    break;
                case "TIPOVISITANTES":
                    break;
                case "VISITANTES":
                    break;
                case "VISITAS":
                    break;
                case "USUARIOS":
                    break;

                default:
                    dtResultado = null;
                    break;
            }



            return dtResultado;
        }

        public string Insertar(string que_voy_a_insertar)
        {
            string msj = string.Empty;

            switch (que_voy_a_insertar.ToUpper())
            {
                case "ACTIVIDADES":
                    msj = "Operación exitosa";
                    break;
                case "HORARIOS":
                    msj = "Operación exitosa";
                    break;
                case "RESIDENTES":
                    msj = "Operación exitosa";
                    break;
                case "TIPOVISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITAS":
                    msj = "Operación exitosa";
                    break;
                case "USUARIOS":
                    msj = "Operación exitosa";
                    break;

                default:
                    msj = null;
                    break;
            }
            
            return msj;
        }

        public string Modificar(string que_voy_a_modificar)
        {
            string msj = string.Empty;

            switch (que_voy_a_modificar.ToUpper())
            {
                case "ACTIVIDADES":
                    msj = "Operación exitosa";
                    break;
                case "HORARIOS":
                    msj = "Operación exitosa";
                    break;
                case "RESIDENTES":
                    msj = "Operación exitosa";
                    break;
                case "TIPOVISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITAS":
                    msj = "Operación exitosa";
                    break;
                case "USUARIOS":
                    msj = "Operación exitosa";
                    break;

                default:
                    msj = null;
                    break;
            }

            return msj;
        }

        public string Eliminar(string que_voy_a_eliminar)
        {
            string msj = string.Empty;

            switch (que_voy_a_eliminar.ToUpper())
            {
                case "ACTIVIDADES":
                    msj = "Operación exitosa";
                    break;
                case "HORARIOS":
                    msj = "Operación exitosa";
                    break;
                case "RESIDENTES":
                    msj = "Operación exitosa";
                    break;
                case "TIPOVISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITANTES":
                    msj = "Operación exitosa";
                    break;
                case "VISITAS":
                    msj = "Operación exitosa";
                    break;
                case "USUARIOS":
                    msj = "Operación exitosa";
                    break;

                default:
                    msj = null;
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
