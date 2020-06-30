using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais.ANIMAIS
{
    class Galinha : Ave, IOviparo
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="deRapina"></param>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        public Galinha(bool deRapina, bool carne, bool peconhento)
        {
            Rapina = deRapina;
            Carnivoro = carne;
            Peconhento = peconhento;
        }

        #region MÉTODOS
        public void Botar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.GalinhaBotando;
        }

        public void Chocar(ref PictureBox pctAnimal)
        {
            pctAnimal.BackgroundImage = Resources.GalinhaChocando;
        }
        #endregion


        public override string ToString()
        {
            return "GALINHA" + Environment.NewLine + base.ToString();
        }
    }
}



