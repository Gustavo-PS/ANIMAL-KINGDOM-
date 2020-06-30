using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais.ANIMAIS
{
    class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        /// <param name="terra"></param>
        /// <param name="mergulho"></param>
        /// <param name="agua"></param>
        public Ornitorrinco(bool carne, bool peconhento, bool pelo, 
            bool terra, bool mergulho, bool agua)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Pelos = pelo;
            ViveEmTerra = terra;
            Mergulha = mergulho;
            AguaDoce = agua;
        }

        #region PARÂMETROS
        private bool viveTerra, mergulha, aguaDoce;

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

        #region MÉTODOS

        public void Botar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.ornitorrincoovo;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            throw new NotImplementedException();
        }
        #endregion

        public override string ToString()
        {
            return "ORNITORRINCO" + Environment.NewLine + base.ToString() + "MERGULHA" + Environment.NewLine +
                "VIVE EM TERRA" + Environment.NewLine + "ÁGUA DOCE" + Environment.NewLine;
        }

    }
}
