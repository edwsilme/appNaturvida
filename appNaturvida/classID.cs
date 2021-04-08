using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appNaturvida
{
    class classID
    {
        #region "Atributos"
        string codigoID;
        string id;
        #endregion

        #region "Propiedades"

        public string CodigoID
        {
            set { codigoID = value; }
            get { return codigoID; }
        }

        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        #endregion
    }
}
