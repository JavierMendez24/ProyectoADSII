using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    class Contratos
    {
        String _ID_Contrato;
        String _ID_Cliente;
        String _Tipo_Contrato;
        String _Numero_Zonas;
        String _Costo_Arrendamiento;
        String _Inicio_Arrendamiento;
        String _Fin_Arrendamiento;
        String _Estado;

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

        public string ID_Cliente
        {
            get
            {
                return _ID_Cliente;
            }

            set
            {
                _ID_Cliente = value;
            }
        }

        public string Tipo_Contrato
        {
            get
            {
                return _Tipo_Contrato;
            }

            set
            {
                _Tipo_Contrato = value;
            }
        }

        public string Numero_Zonas
        {
            get
            {
                return _Numero_Zonas;
            }

            set
            {
                _Numero_Zonas = value;
            }
        }

        public string Costo_Arrendamiento
        {
            get
            {
                return _Costo_Arrendamiento;
            }

            set
            {
                _Costo_Arrendamiento = value;
            }
        }

        public string Inicio_Arrendamiento
        {
            get
            {
                return _Inicio_Arrendamiento;
            }

            set
            {
                _Inicio_Arrendamiento = value;
            }
        }

        public string Fin_Arrendamiento
        {
            get
            {
                return _Fin_Arrendamiento;
            }

            set
            {
                _Fin_Arrendamiento = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO contratos(ID_Cliente, Tipo_Contrato, Numero_Zonas, Costo_Arrendamiento, Inicio_Arrendamiento, Fin_Arrendamiento, Estado)
                                 VALUES ("+this._ID_Cliente+", '"+this._Tipo_Contrato+"', (SELECT SUM(ISNULL(ID_Contrato)) FROM Detalle_Contrato), '"+this._Costo_Arrendamiento+"', '"+this._Inicio_Arrendamiento+"', '"+this._Fin_Arrendamiento+"', 'ACTIVO');";

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

        public Boolean GuardarContratoEnZona()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE Detalle_Contrato SET ID_Contrato = "+this._ID_Contrato+" WHERE ISNULL(ID_Contrato);";

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
            String Sentencia = @"UPDATE contratos SET ID_Cliente = "+this._ID_Cliente+", Numero_Zonas = "+this._Numero_Zonas+", Costo_Arrendamiento = '"+this._Costo_Arrendamiento+"', Inicio_Arrendamiento = '"+this._Inicio_Arrendamiento+"', Fin_Arrendamiento = '"+this._Fin_Arrendamiento+@"', Estado = 'ACTIVO'
                                 WHERE ID_Contrato = "+this._ID_Contrato+";";

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
