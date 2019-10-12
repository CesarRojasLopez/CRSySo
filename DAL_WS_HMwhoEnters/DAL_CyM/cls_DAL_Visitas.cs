using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_Visitas
    {
        private string _CEDULA_RESIDENTE;
        private string _CEDULA_VISITANTE;
        private DateTime _FECHA_HORA_INGRESO;
        private DateTime _FECHA_HORA_SALIDA;
        private int _ID_ACTIVIDAD;
        private int _ID_HORARIO_VISITADO;
        private int _ID_VISITA;
        private int _TIPO_VISITANTE;
        private int _USUARIO_CREACION;

        public string CEDULA_RESIDENTE
        {
            get
            {
                return _CEDULA_RESIDENTE;
            }

            set
            {
                _CEDULA_RESIDENTE = value;
            }
        }

        public string CEDULA_VISITANTE
        {
            get
            {
                return _CEDULA_VISITANTE;
            }

            set
            {
                _CEDULA_VISITANTE = value;
            }
        }

        public DateTime FECHA_HORA_INGRESO
        {
            get
            {
                return _FECHA_HORA_INGRESO;
            }

            set
            {
                _FECHA_HORA_INGRESO = value;
            }
        }

        public DateTime FECHA_HORA_SALIDA
        {
            get
            {
                return _FECHA_HORA_SALIDA;
            }

            set
            {
                _FECHA_HORA_SALIDA = value;
            }
        }

        public int ID_ACTIVIDAD
        {
            get
            {
                return _ID_ACTIVIDAD;
            }

            set
            {
                _ID_ACTIVIDAD = value;
            }
        }

        public int ID_HORARIO_VISITADO
        {
            get
            {
                return _ID_HORARIO_VISITADO;
            }

            set
            {
                _ID_HORARIO_VISITADO = value;
            }
        }

        public int ID_VISITA
        {
            get
            {
                return _ID_VISITA;
            }

            set
            {
                _ID_VISITA = value;
            }
        }

        public int TIPO_VISITANTE
        {
            get
            {
                return _TIPO_VISITANTE;
            }

            set
            {
                _TIPO_VISITANTE = value;
            }
        }

        public int USUARIO_CREACION
        {
            get
            {
                return _USUARIO_CREACION;
            }

            set
            {
                _USUARIO_CREACION = value;
            }
        }
    }
}
