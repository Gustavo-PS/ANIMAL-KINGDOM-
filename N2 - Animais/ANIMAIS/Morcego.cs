using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais.ANIMAIS
{
    class Morcego : Mamifero, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Morcego(bool carne, bool peconhento, bool pelo)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Pelos = pelo;
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
                    throw new Exception("A altura máxima em que uma ave pode voar deve variar de 1m a 12000m!");
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
                    throw new Exception("A velocidade máxima em que uma ave pode voar deve variar de 1km/h a 350km/h!");
            }
        }
        #endregion

        #region MÉTODOS

        public void Voar(ref PictureBox pctAnimal, ref Panel pnl)
        {
            pctAnimal.Location = new Point(294, 46);
        }
        #endregion

        public override string ToString()
        {
            return "MORCEGO" + Environment.NewLine + base.ToString() + Environment.NewLine + "ALTURA MÁXIMA DE VOO EM METROS: "
                + AlturaMaximaM + Environment.NewLine + "VELOCIDADE DE VOO: " + VelocidadeVoo;
        }
    }
}
