﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGeneral.CLS
{
    class Permisos
    {
        String _IDPermiso;
        String _IDOpcion;
        String _IDRol;

        public string IDPermiso
        {
            get
            {
                return _IDPermiso;
            }

            set
            {
                _IDPermiso = value;
            }
        }

        public string IDOpcion
        {
            get
            {
                return _IDOpcion;
            }

            set
            {
                _IDOpcion = value;
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

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO permisos(ID_Rol, ID_Opcion) VALUES(" + this._IDRol + ", " + this._IDOpcion + ");";
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
            String Sentencia = @"DELETE FROM permisos WHERE ID_Permiso = " + this._IDPermiso + ";";
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
