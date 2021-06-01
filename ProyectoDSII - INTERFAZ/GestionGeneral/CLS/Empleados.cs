using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGeneral.CLS
{
    class Empleados
    {
        // ATRIBUTOS
        String _IDEmpleado;
        String _DUI;
        String _NIT;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Genero;
        String _Telefono;
        String _Direccion;
        String _Correo;

        // PROPIEDADES
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

        public string FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
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

        // METODOS
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO empleados(DUI, NIT, Nombres, Apellidos, FechaNacimiento, Genero, Telefono, Direccion, Correo) VALUES('" + this._DUI + "','" + this._NIT + "','" + this._Nombres + "','" + this._Apellidos + "','" + this._FechaNacimiento + "','" + this._Genero + "','" + this._Telefono + "','" + this._Direccion + "','" + this._Correo + "');";

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

        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE empleados SET DUI = '"+ this._DUI +"', NIT='"+this._NIT+"', Nombres='"+ this._Nombres +"', Apellidos='"+this._Apellidos+"', FechaNacimiento='"+this._FechaNacimiento+"', Genero='"+this._Genero+"', Telefono='"+this._Telefono+"', Direccion='"+this._Direccion+"', Correo='"+this._Correo+
                                "' WHERE ID_Empleado ="+ this._IDEmpleado +"; ";

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
            String Sentencia = @"DELETE FROM empleados WHERE ID_Empleado =" + this._IDEmpleado + "; ";

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
