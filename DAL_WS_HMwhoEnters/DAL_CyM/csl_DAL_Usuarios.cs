using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class csl_DAL_Usuarios
    {
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private int _ID_USUARIO;
        private string _PASWORD;
        private string _ROL;
        private string _USUARIO;
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

        public int ID_USUARIO
        {
            get
            {
                return _ID_USUARIO;
            }

            set
            {
                _ID_USUARIO = value;
            }
        }

        public string PASWORD
        {
            get
            {
                return _PASWORD;
            }

            set
            {
                _PASWORD = value;
            }
        }

        public string ROL
        {
            get
            {
                return _ROL;
            }

            set
            {
                _ROL = value;
            }
        }

        public string USUARIO
        {
            get
            {
                return _USUARIO;
            }

            set
            {
                _USUARIO = value;
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
