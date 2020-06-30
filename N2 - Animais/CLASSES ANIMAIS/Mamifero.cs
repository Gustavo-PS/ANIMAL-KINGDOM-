using N2___Animais.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    public class Mamifero:Animal
    {
        int qtdeMamas;
        string corPelo;
        #region ...PROPRIEDADES...

        public int QtdeMamas
        {
            get
            {
                return qtdeMamas;
            }

            set
            {
                if (value < 0)
                    throw new Exception("A quantidade de mamas deve ser maior ou igual a 0!");
                else
                    qtdeMamas = value;
            }
        }

        public bool Pelos
        { get; set; }

        public string CorPelo
        {
            get
            {
                return corPelo;
            }

            set
            {
                if (value == "")
                    throw new Exception("Informe a cor de pelo!");
                else
                    corPelo = value;
            }
        }

        #endregion

        /// <summary>
        /// Método referente a ação de amamentar do mamífero
        /// </summary>
        public void Amamentar(string tag, ref PictureBox pctAnimal)
        {
            switch (tag)
            {
                case "baleia":
                    pctAnimal.BackgroundImage = Resources.Baleia;
                    //btnMovimentar.Enabled = false;
                    break;

                case "cachorro":
                    pctAnimal.BackgroundImage = Resources.Cachorro;
                   // btnMovimentar.Enabled = false;
                    break;

                case "elefante":
                    pctAnimal.BackgroundImage = Resources.Elefante;
                  //  btnMovimentar.Enabled = false;
                    break;

                case "gato":
                    pctAnimal.BackgroundImage = Resources.Gato;
                  //  btnMovimentar.Enabled = false;
                    break;

                case "leao":
                    pctAnimal.BackgroundImage = Resources.Leao;
                 //   btnMovimentar.Enabled = false;
                    break;

                case "morcego":
                    pctAnimal.BackgroundImage = Resources.Morcego;
                  //  btnMovimentar.Enabled = false;
                    break;
            }
        }

        public override string ToString()
        {
            if (Pelos)
                return base.ToString() + "QUANTIDADE DE MAMAS: " + QtdeMamas + Environment.NewLine +
                "POSSUI PELOS" + Environment.NewLine + CorPelo + Environment.NewLine;
            else
                return base.ToString() + "QUANTIDADE DE MAMAS: " + QtdeMamas + Environment.NewLine;
        }
    }
}
