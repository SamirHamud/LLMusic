using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMusic
{
    class No
    {
        private string _valor;
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        private No _proximo;
        public No Proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }
    }
}
