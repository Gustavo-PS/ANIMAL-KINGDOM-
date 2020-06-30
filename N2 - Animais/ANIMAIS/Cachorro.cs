using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Cachorro: Mamifero
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Cachorro(bool carne, bool peconhento,bool pelo)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Pelos = pelo;
        }

        public override string ToString()
        {
            return "CACHORRO" +Environment.NewLine+ base.ToString();
        }
    }
}
