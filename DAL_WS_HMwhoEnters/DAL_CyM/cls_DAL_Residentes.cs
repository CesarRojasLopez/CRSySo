using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_Residentes
    {
        private string _APELLIDOS;
        private string _CEDULA;
        private string _CORREO_CONTACTO;
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private DateTime _FECHA_INGRESO;
        private DateTime _FECHA_ULT_VISITA;
        private string _GENERO;
        private string _NOMBRE;
        private string _NOMBRE_CONTACTO;
        private string _TEL_CONTACTO;
        private int _USUARIO_CREACION;

        public string APELLIDOS
        {
            get
            {
                return _APELLIDOS;
            }

            set
            {
                _APELLIDOS = value;
            }
        }

        public string CEDULA
        {
            get
            {
                return _CEDULA;
            }

            set
            {
                _CEDULA = value;
            }
        }

        public string CORREO_CONTACTO
        {
            get
            {
                return _CORREO_CONTACTO;
            }

            set
            {
                _CORREO_CONTACTO = value;
            }
        }

        public char ESTADO
        {
            get
            {
                return _ESTADO;
            }

            set
            {
                _ESTADO = value;
            }
        }

        public DateTime FECHA_CREACION
        {
            get
            {
                return _FECHA_CREACION;
            }

            set
            {
                _FECHA_CREACION = value;
            }
        }

        public DateTime FECHA_INGRESO
        {
            get
            {
                return _FECHA_INGRESO;
            }

            set
            {
                _FECHA_INGRESO = value;
            }
        }

        public DateTime FECHA_ULT_VISITA
        {
            get
            {
                return _FECHA_ULT_VISITA;
            }

            set
            {
                _FECHA_ULT_VISITA = value;
            }
        }

        public string GENERO
        {
            get
            {
                return _GENERO;
            }

            set
            {
                _GENERO = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return _NOMBRE;
            }

            set
            {
                _NOMBRE = value;
            }
        }

        public string NOMBRE_CONTACTO
        {
            get
            {
                return _NOMBRE_CONTACTO;
            }

            set
            {
                _NOMBRE_CONTACTO = value;
            }
        }

        public string TEL_CONTACTO
        {
            get
            {
                return _TEL_CONTACTO;
            }

            set
            {
                _TEL_CONTACTO = value;
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
