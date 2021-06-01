using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGeneral.CLS
{
    class Usuarios
    {
        String _IDUsuario;
        String _IDRol;
        String _IDEmpleado;
        String _Usuario;
        String _Clave;

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }

        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }

        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }

        // Guardar Usuarios
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"insert into usuarios(ID_Rol, ID_Empleado, Usuario, Clave) values (" + this._IDRol + ", " + this._IDEmpleado + ", '" + this._Usuario + "', SHA1(MD5('" + this._Clave + "')));";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;

        }

        // Editar Usuarios
        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE usuarios SET ID_Rol = "+this._IDRol+", ID_Empleado = "+this._IDEmpleado+", Usuario = '"+this._Usuario+"', Clave = sha1(md5('"+this._Clave+@"')) 
                                 WHERE ID_Usuario = "+this._IDUsuario+"; ";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;

        }

        // Eliminar Usuarios
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM usuarios WHERE ID_Usuario = " + this._IDUsuario + "; ";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;

        }
    }
}
