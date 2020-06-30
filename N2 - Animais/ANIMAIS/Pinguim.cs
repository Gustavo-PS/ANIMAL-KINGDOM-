using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais.ANIMAIS
{
    class Pinguim : Ave, IOviparo,IAquatico
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        public Pinguim(bool carne, bool peconhento, bool rapina,bool terra, bool mergulho, bool agua)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
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
        public void Botar(ref PictureBox pctAnimal )
        {
            pctAnimal.BackgroundImage = Resources.pinguim_ovo;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.pinguimchocando;
        }
        #endregion

        public override string ToString()
        {
            return "PINGUIM" + Environment.NewLine + base.ToString() + Environment.NewLine + "VIVE EM TERRA" + Environment.NewLine +
                "MERGULHA" + Environment.NewLine ;
        }
    }
}
