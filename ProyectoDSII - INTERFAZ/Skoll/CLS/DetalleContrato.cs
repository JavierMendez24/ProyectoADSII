using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    class DetalleContrato
    {
        String _ID_Detalle_Contrato;
        String _ID_Contrato;
        String _ID_Zona;

        public string ID_Detalle_Contrato
        {
            get
            {
                return _ID_Detalle_Contrato;
            }

            set
            {
                _ID_Detalle_Contrato = value;
            }
        }

        public string ID_Contrato
        {
            get
            {
                return _ID_Contrato;
            }

            set
            {
                _ID_Contrato = value;
            }
        }

        public string ID_Zona
        {
            get
            {
                return _ID_Zona;
            }

            set
            {
                _ID_Zona = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Detalle_Contrato(ID_Zona) VALUES ("+this._ID_Zona+");";
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

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM Detalle_Contrato WHERE ID_Detalle_Contrato = "+this._ID_Detalle_Contrato+";";
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
