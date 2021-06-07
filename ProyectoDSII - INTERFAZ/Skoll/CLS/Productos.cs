using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    class Productos
    {
        private String _ID_Producto;
        String _ID_Catalogo;
        String _Costo;
        String _Cantidad;
        String _Fecha_Vencimiento;

        public string ID_Producto
        {
            get
            {
                return _ID_Producto;
            }

            set
            {
                _ID_Producto = value;
            }
        }

        public string ID_Catalogo
        {
            get
            {
                return _ID_Catalogo;
            }

            set
            {
                _ID_Catalogo = value;
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

        public string Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public string Fecha_Vencimiento
        {
            get
            {
                return _Fecha_Vencimiento;
            }

            set
            {
                _Fecha_Vencimiento = value;
            }
        }

        
        //METODOS
        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO productos(ID_Catalogo, Costo, Cantidad, Fecha_Vencimiento) VALUES ("+this._ID_Catalogo+", '"+this._Costo+"', "+this._Cantidad+", '"+this._Fecha_Vencimiento+"')";

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

        public Boolean GuardarZonaProducto(String pIDZona)
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO detalle_zona_productos(ID_Producto, ID_Zona) VALUES("+this._ID_Producto+", "+pIDZona+");";

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

        public Boolean GuardarProductoMovimiento()
        {
            Boolean Resultado = false;
            String Sentencia = @"insert into detalle_movimientos_productos(ID_Producto) values ("+this._ID_Producto+");";

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
