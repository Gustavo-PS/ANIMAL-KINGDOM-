using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    class ComparadorNome : IComparer
    {
        //se retornar -1 então x é menor que y
        //se retornar 0 x é igual a y
        //se retornar 1 x é maior que y
        public int Compare(object x, object y)
        {
            return (x as Animal).Nome.CompareTo((y as Animal).Nome);
        }
    }
}

