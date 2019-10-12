using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_Actividades
    {
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private int _ID_ACTIVIDAD;
        private string _NOMBRE_ACTIVIDAD;
        private int _USUARIO_CREACION;

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

        public string NOMBRE_ACTIVIDAD
        {
            get
            {
                return _NOMBRE_ACTIVIDAD;
            }

            set
            {
                _NOMBRE_ACTIVIDAD = value;
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
