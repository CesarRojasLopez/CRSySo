using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_TipoVisitante
    {
        private string _DESCRIPCION;
        private string _DETALLE;
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private int _ID_TIPO_VISITANTE;
        private string _NOMENCLATURA;
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

        public string DETALLE
        {
            get
            {
                return _DETALLE;
            }

            set
            {
                _DETALLE = value;
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

        public int ID_TIPO_VISITANTE
        {
            get
            {
                return _ID_TIPO_VISITANTE;
            }

            set
            {
                _ID_TIPO_VISITANTE = value;
            }
        }

        public string NOMENCLATURA
        {
            get
            {
                return _NOMENCLATURA;
            }

            set
            {
                _NOMENCLATURA = value;
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
