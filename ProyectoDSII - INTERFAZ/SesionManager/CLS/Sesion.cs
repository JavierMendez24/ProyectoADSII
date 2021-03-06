using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesionManager.CLS
{
    public sealed class Sesion
    {
        private static Sesion instancia = null;
        private static object padlock = new object();

        //MIS ATRIBUTOS
        String _Usuario;
        String _Rol;
        String _IDUsuario;
        String _Empleado;

        public static Sesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    lock (padlock)
                    {
                        if (instancia == null)
                        {
                            instancia = new Sesion();
                        }
                    }
                }
                return instancia;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }
        }

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }
        }

        public string Empleado
        {
            get
            {
                return _Empleado;
            }
        }

        private Sesion()
        {
            _Usuario = "N/A";
        }

        public Boolean IniciarSesion(String pUsuario, String pClave)
        {
            Boolean Autorizado = false;
            DataTable DatosSesion = new DataTable();
            try
            {
                DatosSesion = CacheManager.CLS.Cache.INICIAR_SESION(pUsuario, pClave);
                if (DatosSesion.Rows.Count == 1)
                {
                    _Usuario = DatosSesion.Rows[0]["Usuario"].ToString();
                    _IDUsuario = DatosSesion.Rows[0]["ID_Usuario"].ToString();
                    _Rol = DatosSesion.Rows[0]["Rol"].ToString();
                    _Empleado = DatosSesion.Rows[0]["Empleado"].ToString();
                    Autorizado = true;
                }
                else
                {
                    Autorizado = false;
                }
            }
            catch
            {
                Autorizado = false;
            }

            return Autorizado;
        }
    }
}
