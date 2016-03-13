using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opticaMedilent.clases
{
  public class Usuario
    {
        private string _userKey;
        private string _userPass;
        /// <summary>
        /// Metodo que retorna el Valor del Key del Usuario
        /// </summary>
        public string getSetUserKey
        {
            get { return this._userKey; }
            set { this._userKey = value; }
        }
        /// <summary>
        /// Metodo que retorna el valor del usuario
        /// </summary>
        public string getSetUserPassword
        {
            get { return this._userPass; }
            set { this._userPass = value; } 
        }

    }
}
