using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    class Movimientos
    {
        String _ID_Movimiento;
        String _Tipo_Movimiento;
        String _ID_Usuario;
        String _Fecha;
        String _Nombre_Cliente;
        String _Zona;
        String _Nombre_Producto;
        String _Marca;
        String _Costo;
        String _Cantidad_Anterior;
        String _Cantidad_Movimiento;
        String _Cantidad_Actual;

        public string ID_Movimiento
        {
            get
            {
                return _ID_Movimiento;
            }

            set
            {
                _ID_Movimiento = value;
            }
        }

        public string Tipo_Movimiento
        {
            get
            {
                return _Tipo_Movimiento;
            }

            set
            {
                _Tipo_Movimiento = value;
            }
        }

        public string ID_Usuario
        {
            get
            {
                return _ID_Usuario;
            }

            set
            {
                _ID_Usuario = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public string Nombre_Cliente
        {
            get
            {
                return _Nombre_Cliente;
            }

            set
            {
                _Nombre_Cliente = value;
            }
        }

        public string Zona
        {
            get
            {
                return _Zona;
            }

            set
            {
                _Zona = value;
            }
        }

        public string Nombre_Producto
        {
            get
            {
                return _Nombre_Producto;
            }

            set
            {
                _Nombre_Producto = value;
            }
        }

        public string Marca
        {
            get
            {
                return _Marca;
            }

            set
            {
                _Marca = value;
            }
        }

        public string Costo
        {
            get
            {
                return _Costo;
            }

            set
            {
                _Costo = value;
            }
        }

        public string Cantidad_Anterior
        {
            get
            {
                return _Cantidad_Anterior;
            }

            set
            {
                _Cantidad_Anterior = value;
            }
        }

        public string Cantidad_Movimiento
        {
            get
            {
                return _Cantidad_Movimiento;
            }

            set
            {
                _Cantidad_Movimiento = value;
            }
        }

        public string Cantidad_Actual
        {
            get
            {
                return _Cantidad_Actual;
            }

            set
            {
                _Cantidad_Actual = value;
            }
        }

        public Boolean Guardar(String pIDCatalogo)
        {
            Boolean Resultado = false;
            String Sentencia = @"CAll MovimientoEntrada('Entrada', "+this._ID_Usuario+", '"+this._Zona+"', '"+this._Nombre_Producto+"', '"+this._Costo+"', "+this._Cantidad_Movimiento+", '"+this._Nombre_Cliente+"', '"+pIDCatalogo+"', (SELECT CURDATE()));";

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

        public Boolean GuardarMovimientoProducto()
        {
            Boolean Resultado = false;
            String Sentencia = @"update detalle_movimientos_productos set ID_Movimiento = "+this._ID_Movimiento+" where isnull(ID_Movimiento);";

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
    }
}
