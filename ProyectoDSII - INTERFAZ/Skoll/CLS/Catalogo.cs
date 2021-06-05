using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    public class Catalogo
    {
        String _ID_Catalogo;
        String _Marca;
        String _Nombre_Producto;
        String _Categoria;
        String _Descripcion;

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

        public string Categoria
        {
            get
            {
                return _Categoria;
            }

            set
            {
                _Categoria = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Catalogo(Marca, Nombre_Producto, Categoria, Descripcion) VALUES('" + this._Marca + "','" + this._Nombre_Producto + "','" + this._Categoria + "','" + this._Descripcion + "');";

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
            String Sentencia = @"UPDATE Catalogo SET Marca = '" + this._Marca + "', Nombre_Producto='" + this._Nombre_Producto + "', Categoria='" + this._Categoria + "', Descripcion='" + this._Descripcion +
                                "' WHERE ID_Catalogo =" + this._ID_Catalogo + "; ";

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
            String Sentencia = @"DELETE FROM Catalogo WHERE ID_Catalogo =" + this._ID_Catalogo + "; ";

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
