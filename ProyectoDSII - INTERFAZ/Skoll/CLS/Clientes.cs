using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    class Clientes
    {
        //PRPOPIEDADES
        String _IDCliente;
        String _TipoCliente;
        String _DUI;
        String _NIT;
        String _Nombres;
        String _Apellidos;
        String _RazonSocial;
        String _Telefono;
        String _Direccion;
        String _Correo;

        //ATRIBUTOS
        public string IDCliente
        {
            get
            {
                return _IDCliente;
            }

            set
            {
                _IDCliente = value;
            }
        }

        public string TipoCliente
        {
            get
            {
                return _TipoCliente;
            }

            set
            {
                _TipoCliente = value;
            }
        }

        public string DUI
        {
            get
            {
                return _DUI;
            }

            set
            {
                _DUI = value;
            }
        }

        public string NIT
        {
            get
            {
                return _NIT;
            }

            set
            {
                _NIT = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return _RazonSocial;
            }

            set
            {
                _RazonSocial = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Correo
        {
            get
            {
                return _Correo;
            }

            set
            {
                _Correo = value;
            }
        }

        //METODOS
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Clientes(Tipo_Cliente, DUI, NIT, Nombres_Cliente, Apellidos_Cliente, Nombre_Empresa, Telefono, Direccion, Correo) VALUES('" + this._TipoCliente + "','" + this._DUI + "','" + this._NIT + "','" + this._Nombres + "','" + this._Apellidos + "','" + this._RazonSocial + "','" + this._Telefono + "','" + this._Direccion + "','" + this._Correo + "');";

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

        /*
        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE Roles SET Rol ='" + this._Rol + "' WHERE IDRol =" + this.IDRol + ";";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Actualizar(Sentencia) > 0)
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

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM Roles WHERE IDRol =" + this.IDRol + ";";

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
        */
    }
}
