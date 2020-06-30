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
    class Coruja : Ave, IOviparo, IVoar, IPredador
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="deRapina"></param>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        public Coruja(bool deRapina, bool carne, bool peconhento)
        {
            Rapina = deRapina;
            Carnivoro = carne;
            Peconhento = peconhento;
        }

        #region PARÂMETROS
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
        public void Ataque(ref PictureBox pctAnimal, ref Label lblComunica)
        {
            pctAnimal.BackgroundImage = Resources.Corujacomendo;
            lblComunica.ForeColor = Color.White;
            lblComunica.Text = "QUE RATINHO GOSTOSO";
        }

        public void Botar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.corujaovo;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.corujachocando;
        }

        public void Voar(ref PictureBox pctAnimal, ref Panel pnlFundoAcao)
        {
            pctAnimal.Location = new Point(294, 46);
        }
        #endregion

        public override string ToString()
        {
            return "CORUJA" +Environment.NewLine+ base.ToString() + "ALTURA MÁXIMA DE VOO EM METROS: " + AlturaMaximaM + Environment.NewLine +
                "VELOCIDADE DE VOO: " + VelocidadeVoo + Environment.NewLine + "PREDADOR" + Environment.NewLine;
        }
    }
}
