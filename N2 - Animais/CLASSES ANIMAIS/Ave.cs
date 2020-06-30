using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    class Ave:Animal
    {
        string corpena;
        #region ... PROPRIEDADES ...

        public bool Rapina
        { get; set; }

        public string CorPena
        {
            get
            {
                return corpena;
            }

            set
            {
                if (value == "")
                    throw new Exception("Informe a cor de pena!");
                else
                    corpena = value;
            }
        }

        #endregion

        /// <summary>
        /// Método referente a ação de ciscar da ave
        /// </summary>
        public void Ciscar(string tag, ref PictureBox pctAnimal, ref Label lblComunica)
        {
            switch (tag)
            {
                
                case "coruja":
                    pctAnimal.Location = new Point(302, 333);
                    lblComunica.ForeColor = Color.White;
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;

                case "galinha":
                    pctAnimal.BackgroundImage = Resources.Galinhacomendo;
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;

                case "gaviao":
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;

                case "pato":
                    pctAnimal.BackgroundImage = Resources.Patocomendo;
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;

                case "pinguim":
                    pctAnimal.BackgroundImage = Resources.Pinguimcomendo;
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;

                case "pombo":
                    pctAnimal.BackgroundImage = Resources.Pombocomendo;
                    lblComunica.Text = "PIC PIC PIC PIC";
                    break;
            }
        }

        public override string ToString()
        {
            if(Rapina)
               return base.ToString() + "COR DA PENA: " + CorPena + 
                    Environment.NewLine + "AVE DE RAPINA" + Environment.NewLine;
            else
                return base.ToString() + "COR DA PENA: " + CorPena + Environment.NewLine;
        }
    }
}
