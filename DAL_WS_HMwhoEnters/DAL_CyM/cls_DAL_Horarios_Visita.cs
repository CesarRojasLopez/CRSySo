using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_Horarios_Visita
    {
        private string _DESCRIPCION;
        private string _DIA_SEMANA;
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private DateTime _H_FIN;
        private DateTime _H_INICIO;
        private int _ID_HORARIO;
        private int _USUARIO_CREACION;

        public string DESCRIPCION
        {
            get
            {
                return _DESCRIPCION;
            }

            set
            {
                _DESCRIPCION = value;
            }
        }

        public string DIA_SEMANA
        {
            get
            {
                return _DIA_SEMANA;
            }

            set
            {
                _DIA_SEMANA = value;
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

        public DateTime H_FIN
        {
            get
            {
                return _H_FIN;
            }

            set
            {
                _H_FIN = value;
            }
        }

        public DateTime H_INICIO
        {
            get
            {
                return _H_INICIO;
            }

            set
            {
                _H_INICIO = value;
            }
        }

        public int ID_HORARIO
        {
            get
            {
                return _ID_HORARIO;
            }

            set
            {
                _ID_HORARIO = value;
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
