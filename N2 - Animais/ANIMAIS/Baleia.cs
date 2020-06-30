using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    public class Baleia : Mamifero, IAquatico
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="terra"></param>
        /// <param name="mergulho"></param>
        /// <param name="agua"></param>
        /// <param name="peconhento"></param>
        /// <param name="carne"></param>
        /// <param name="pelo"></param>
        public Baleia(bool terra, bool mergulho, bool agua, bool peconhento, bool carne, bool pelo)
        {
            ViveEmTerra = terra;
            Mergulha = mergulho;
            AguaDoce = agua;
            Peconhento = peconhento;
            Carnivoro = carne;
            Pelos = pelo;

        }

        private bool viveTerra, mergulha, aguaDoce;

        #region PARÂMETROS
        public bool ViveEmTerra
        {
            get => viveTerra;
            set => viveTerra = value;
        }
        public bool Mergulha
        {
            get => mergulha;
            set => mergulha = value;
        }
        public bool AguaDoce
        {
            get => aguaDoce;
            set => aguaDoce = value;
        }
        #endregion

        public override string ToString()
        {
            return "BALEIA" +Environment.NewLine+ base.ToString() + "MERGULHA" + Environment.NewLine;
        }

    }
}
