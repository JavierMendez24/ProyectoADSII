using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoll.CLS
{
    public class TransferenciaDatos
    {
        private static TransferenciaDatos _instance;
        
        // ATRIBUTOS
        private Hashtable _Valores = new Hashtable();
        private int _Ultimo = -1;

        // PROPIEDADES
        public Hashtable Valores
        {
            get
            {
                return _Valores;
            }

            set
            {
                _Valores = value;
            }
        }
        public int Ultimo
        {
            get
            {
                return _Ultimo;
            }

            set
            {
                _Ultimo = value;
            }
        }

        private TransferenciaDatos()
        {
        }

        public static TransferenciaDatos getInstance()
        {
            if( _instance == null){
                _instance = new TransferenciaDatos();
            }

            return _instance;
        }
        


    }
}
