using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Elefante:Mamifero
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Elefante(bool carne, bool peconhento,bool pelo)
        {
            Carnivoro = carne;
            Pelos = pelo;
            Peconhento = peconhento;
        }

        public override string ToString()
        {
            return "ELEFANTE" +Environment.NewLine+ base.ToString();
        }
    }
}
