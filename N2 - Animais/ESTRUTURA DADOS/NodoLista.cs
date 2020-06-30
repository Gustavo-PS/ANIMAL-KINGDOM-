using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    public class NodoLista
    {
        public Animal Dado { get; set; }
        public NodoLista Proximo { get; set; }
        /// <summary>         
        /// Construtor sem parâmetros   
        ///  </summary>        
        public NodoLista()
        {
            //Dado.Nome = string.Empty;
            //Dado.Idade = 0;
            Proximo = null;
        }
    }
}
