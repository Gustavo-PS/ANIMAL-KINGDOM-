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
    class Pombo : Ave, IOviparo, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        public Pombo(bool carne, bool peconhento, bool rapina)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
        }

        #region PARÂMETRO
        private int alturaMaxima;
        private double velocidadeVoo;

        //falta validar altura e velocidade
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
        #endregion

        #region MÉTODOS

        public void Botar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.pomboovo;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.pombochocando;
        }

        public void Voar(ref PictureBox pctAnimal, ref Panel pnlFundoAcao)
        {
            pnlFundoAcao.BackgroundImage = Resources.ceu;
            pctAnimal.Location = new Point(266, 39);
        }
        #endregion

        public override string ToString()
        {
            return "POMBO" + Environment.NewLine + base.ToString() + Environment.NewLine + "ALTURA MÁXIMA DE VOO EM M: " +
                AlturaMaximaM + Environment.NewLine + "VELOCIDADE DE VOO: " + VelocidadeVoo + Environment.NewLine;
                
        }
    }
}
