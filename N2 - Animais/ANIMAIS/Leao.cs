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
    class Leao : Mamifero, IPredador
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carn"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Leao(bool carne, bool peconhento, bool pelo)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Pelos = pelo;
        }

        #region MÉTODOS
        public void Ataque(ref PictureBox pctAnimal, ref Label lblComunica)
        {
            pctAnimal.BackgroundImage = Resources.Leaocomendo;
            lblComunica.Text = "QUE BIFÃO GOSTOSO";
        }
        #endregion

        public override string ToString()
        {
            return "LEÃO" + Environment.NewLine + base.ToString() + "PREDADOR" + Environment.NewLine;
        }
    }
}
