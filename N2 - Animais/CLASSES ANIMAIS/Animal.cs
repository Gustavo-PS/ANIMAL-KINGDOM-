using N2___Animais.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace N2___Animais
{
    public class Animal
    {
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        #region ...PROPRIEDADES...
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (value != "")
                    nome = value;
                else
                    throw new Exception("Atribua um nome ao animal!");
            }

        }


        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                if (value < DateTime.Now)
                    dataNascimento = value;
                else
                    throw new Exception("A data de nascimento nao pode ser futura!");
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                if (value == 'M' || value == 'F')
                    sexo = value;
                else
                    throw new Exception("Atribua um sexo ao animal!");
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (dataNascimento.Month > DateTime.Now.Month)
                    idade = 2020 - dataNascimento.Year - 1;
                else
                    idade = 2020 - dataNascimento.Year - 1;
            }
        }
        public bool Carnivoro
        { get; set; }

        public bool Peconhento
        { get; set; }
        #endregion

        #region ...MÉTODOS...
        /// <summary>
        /// Método referente a ação de movimentar do animal
        /// </summary>
        public void Movimentar(string tag, ref PictureBox pctAnimal)
        {
            switch (tag)
            {
                case "baleia":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "cachorro":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;


                case "coruja":
                    if (pctAnimal.Left < 160)
                    {
                        pctAnimal.Left += 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(39, 221);
                        pctAnimal.Left += 2;
                    }
                    break;

                case "elefante":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "galinha":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "gato":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "gaviao":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "leao":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "morcego":
                    if (pctAnimal.Left < 160)
                    {
                        pctAnimal.Left += 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(39, 221);
                        pctAnimal.Left += 2;
                    }
                    break;

                case "ornitorrinco":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "pato":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "pinguim":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "pombo":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;

                case "tartaruga":
                    if (pctAnimal.Left > 130)
                    {
                        pctAnimal.Left -= 2;
                    }
                    else
                    {
                        pctAnimal.Location = new Point(276, 286);
                        pctAnimal.Left -= 2;
                    }
                    break;
            }
        }

        /// <summary>
        /// Método referente a ação de comunicar do animal
        /// </summary>
        public void Comunicar(string tag, ref Label lblComunica)
        {
            switch (tag)
            {
                case "baleia":
                    lblComunica.Text = "PROCURAAAAAAAAAAAAANDO O NEMO";
                    break;

                case "cachorro":
                    lblComunica.Text = "AUAUAUAUAUAUAUAU";
                    break;

                case "coruja":
                    lblComunica.Text = "PRU PRU PRU PRU";
                    break;

                case "elefante":
                    lblComunica.Text = "EU ADORO AMEOIM";
                    break;

                case "galinha":
                    lblComunica.Text = "PÓ PÔ PÓ? PÓ PÔ";
                    break;

                case "gato":
                    lblComunica.Text = "MIAUUU MIAUUUU";
                    break;

                case "gaviao":
                    lblComunica.Text = "COMO PODE TER DOIS MUNDIAIS E UMA LIBERTADORES?";
                    break;

                case "leao":
                    lblComunica.Text = "OLHE SIMBA TUDO ISSO QUE O SOL TOCA É NOSSO REINO";
                    break;

                case "morcego":
                    lblComunica.Text = "EU SOU O BATMAN";
                    break;

                case "ornitorrinco":
                    lblComunica.Text = "GRRRRRRRRRRRRRRR";
                    break;

                case "pato":
                    lblComunica.Text = "PATO MARCO GOL PATO MARCO GOL";
                    break;

                case "pinguim":
                    lblComunica.Text = "KOWALSKI, RELÁTORIO";
                    break;

                case "pombo":
                    lblComunica.Text = "PRU PRU PRU PRU PRU PRU";
                    break;

                case "tartaruga":
                    lblComunica.Text = "FALOOOU ESQUICHO";
                    break;
            }
        }

        /// <summary>
        /// Método referente a ação de alimentar do animal
        /// </summary>
        public void Alimentar(string tag, ref PictureBox pctAnimal)
        {
            switch (tag)
            {
                case "baleia":
                    //ApagaImagens();
                    //pnlFundoAcao.BackgroundImage = Resources.praia;
                    pctAnimal.BackgroundImage = Resources.Baleiacomendo;
                    break;

                case "cachorro":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.gramado;
                    pctAnimal.BackgroundImage = Resources.Cachorrocomendo;
                    break;

                case "coruja":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.noite;
                    pctAnimal.BackgroundImage = Resources.Corujacomendo;
                    break;

                case "elefante":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Elefantecomendo;
                    break;

                case "galinha":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Galinhacomendo;
                    break;

                case "gato":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.gramado;
                    pctAnimal.BackgroundImage = Resources.Gatocomendo;
                    break;

                case "gaviao":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Gaviaocomendo;
                    break;

                case "leao":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Leaocomendo;
                    break;

                case "morcego":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.noite;
                    pctAnimal.BackgroundImage = Resources.Morcegocomendo;
                    break;

                case "ornitorrinco":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Ornitorrincocomendo;
                    break;

                case "pato":
                    //  ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Patocomendo;
                    break;

                case "pinguim":
                    //  ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.gelo;
                    pctAnimal.BackgroundImage = Resources.Pinguimcomendo;
                    break;

                case "pombo":
                    //  ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.lago;
                    pctAnimal.BackgroundImage = Resources.Pombocomendo;
                    break;

                case "tartaruga":
                    // ApagaImagens();
                    // pnlFundoAcao.BackgroundImage = Resources.praia;
                    pctAnimal.BackgroundImage = Resources.Tartarugacomendo;
                    break;
            }
        }

        public override string ToString()
        {
            string aux = "NOME: " + Nome + Environment.NewLine + "DATA DE NASCIMENTO: " + DataNascimento.ToShortDateString() +
                Environment.NewLine + "IDADE: " + Idade + Environment.NewLine + "SEXO: " + Sexo +
                Environment.NewLine;
            if (Carnivoro)
            {
                if (Peconhento)
                    return aux + "CARNIVORO " + Environment.NewLine + "PEÇONHENTO" + Environment.NewLine;
                else
                    return aux + "CARNIVORO " + Environment.NewLine;

            }
            else
            {
                if (Peconhento)
                    return aux + "PEÇONHENTO" + Environment.NewLine;
                else
                    return aux;
            }


        }
        #endregion
    }
}
