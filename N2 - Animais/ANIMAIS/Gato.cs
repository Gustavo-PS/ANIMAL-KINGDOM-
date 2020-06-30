using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Gato : Mamifero
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Gato(bool carne, bool peconhento,bool pelo)
        {
            Pelos = pelo;
            Carnivoro = carne;
            Peconhento = peconhento;
        }

        public override string ToString()
        {
            return "GATO" + Environment.NewLine+ base.ToString();
        }
    }
}
