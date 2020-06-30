using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais.ANIMAIS
{
    class Pato : Ave, IOviparo, IAquatico, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        /// <param name="terra"></param>
        /// <param name="mergulho"></param>
        /// <param name="agua"></param>
        public Pato(bool carne, bool peconhento, bool rapina,
            bool terra, bool mergulho, bool agua)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
            ViveEmTerra = terra;
            Mergulha = mergulho;
            AguaDoce = agua;
        }

        #region PARÂMETROS

        private int alturaMaxima;
        private double velocidadeVoo;

        public int AlturaMaximaM
        {
            get
            {
                return alturaMaxima;
            }

            set
            {
                if (value > 0 || value < 12000)
                    alturaMaxima = value;
                else
                    throw new Exception("A altura máxima em que um pássaro pode voar deve variar de 1m a 12000m!");
            }
        }
        public double VelocidadeVoo
        {
            get
            {
                return velocidadeVoo;
            }

            set
            {
                if (value > 0 || value < 350)
                    velocidadeVoo = value;
                else
                    throw new Exception("A velocidade máxima em que um pássaro pode voar deve variar de 1km/h a 350km/h!");
            }
        }

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
            pctAnimal.BackgroundImage = Resources.patoovo;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.patochocando;
        }

       
        public void Voar(ref PictureBox pctAnimal, ref Panel pnlFundoAcao)
        {
            pnlFundoAcao.BackgroundImage = Resources.ceu;
            pctAnimal.Location = new Point(266, 39);
        }
        #endregion

        public override string ToString()
        {
            return "PATO" + Environment.NewLine + base.ToString() +Environment.NewLine+ "VIVE EM TERRA" + Environment.NewLine +
                "MERGULHA" + Environment.NewLine + "PODE SER ENCONTRADO EM ÁGUA DOCE" + Environment.NewLine;
        }
    }
}
