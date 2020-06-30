using N2___Animais.ANIMAIS;
using N2___Animais.ESTRUTURA_DADOS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        

        #region MÉTODOS PRIVADOS
        /// <summary>
        /// Carrega o nome do animal no topo e seleciona no combobox invisivel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            label8.Text = $"CADASTRANDO UM(A) {PegaAnimalSelecionado.ToUpper()}";
            label8.Left = (500 - label8.Width)/2;
            label8.Top = 0;
            foreach (string linha in cmbTipoAnimal.Items)
            {
                if (linha.ToUpper() == PegaAnimalSelecionado.ToUpper())
                {
                    cmbTipoAnimal.SelectedItem = linha;
                    break;
                }
            }
        }
        
        /// <summary>
        /// Validação de Espécie do Animal e libera o componente certo para cada um
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoAnimal.SelectedIndex == 0)
            {
                grpMamifero.Enabled = true;
                txtCorPelo.Enabled = false;
                grpAve.Enabled = false;
            }
            else if (cmbTipoAnimal.SelectedIndex > 0 && cmbTipoAnimal.SelectedIndex < 7)
            {
                grpMamifero.Enabled = true;
                grpAve.Enabled = false;
                txtCorPelo.Enabled = true;
            }
            else if (cmbTipoAnimal.SelectedIndex > 6 && cmbTipoAnimal.SelectedIndex < 11)
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = true;
                txtCorPena.Enabled = true;
            }

            else if (cmbTipoAnimal.SelectedIndex > 10 && cmbTipoAnimal.SelectedIndex < 13)
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = true;
                txtCorPena.Enabled = true;
                nmrAlturaMax.Enabled = false;
                nmrVelocidadeMAx.Enabled = false;
            }
            else
            {
                grpMamifero.Enabled = false;
                grpAve.Enabled = false;
            }
        }
        
        /// <summary>
        /// Validações para cadastrar o animal e chama método de instanciamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoAnimal.SelectedIndex >= 0 && cmbTipoAnimal.SelectedIndex < 7)
                    InstanciaMamifero(PegaAnimalSelecionado, txtNome.Text, txtCorPelo.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()), int.Parse(nmrQtdMamas.Text));

                else if (cmbTipoAnimal.SelectedIndex >= 7 && cmbTipoAnimal.SelectedIndex < 13)
                    InstanciaAve(PegaAnimalSelecionado, txtNome.Text, txtCorPena.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()), int.Parse(nmrAlturaMax.Text), int.Parse(nmrVelocidadeMAx.Text));

                else if (cmbTipoAnimal.SelectedIndex == 13)
                    InstanciaReptil(PegaAnimalSelecionado, txtNome.Text, DateTime.Parse(txtDataNascimento.Text), char.Parse(cmbSexo.SelectedItem.ToString()));


                LimpaComponentes();

                MessageBox.Show("Sucesso", "CONCLUÍDO");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

        }

        #endregion

        #region MÉTODOS PÚBLICOS

        /// <summary>
        /// Limpa os componentes do form após o cadastro concluído
        /// </summary>
        public void LimpaComponentes()
        {
            txtNome.Text = String.Empty;
            cmbSexo.SelectedIndex = -1;
            txtDataNascimento.Text = String.Empty;
            txtCorPelo.Text = String.Empty;
            txtCorPena.Text = String.Empty;
            nmrQtdMamas.Value = 0;
            nmrAlturaMax.Value = 0;
            nmrVelocidadeMAx.Value = 0;
        }

        /// <summary>
        /// Pega o animal que foi selecionado pelo usuário 
        /// </summary>
        public string PegaAnimalSelecionado { get; set; }


        #region Métodos de Instanciamento
        /// <summary>
        /// Método para instanciar um mamífero
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public void InstanciaMamifero(string animal, string nome, string corpelo, DateTime nascimento, char sexo, int qtdemamas)
        {
            switch (animal)
            {
                case "baleia":
                 
                        Baleia baleia = new Baleia(false, true, false, false, true, false);
                        baleia.Nome = nome;
                        baleia.DataNascimento = nascimento;
                        baleia.Sexo = sexo;
                        baleia.QtdeMamas = qtdemamas;
                        baleia.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(baleia);
                        break;
                 


                case "cachorro":
                    
                        Cachorro cachorro = new Cachorro(true, false, true);
                        cachorro.Nome = nome;
                        cachorro.CorPelo = corpelo;
                        cachorro.DataNascimento = nascimento;
                        cachorro.Sexo = sexo;
                        cachorro.QtdeMamas = qtdemamas;
                        cachorro.Idade = nascimento.Year;

                        //Adicionar na árvore
                        ArvoreBinaria.Insere(cachorro);

                        break;
                    

                case "elefante":
                    
                        Elefante elefante = new Elefante(false, false, true);
                        elefante.Nome = nome;
                        elefante.CorPelo = corpelo;
                        elefante.DataNascimento = nascimento;
                        elefante.Sexo = sexo;
                        elefante.QtdeMamas = qtdemamas;
                        elefante.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(elefante);
                        break;
                   

                case "gato":
                   
                        Gato gato = new Gato(true, false, true);
                        gato.Nome = nome;
                        gato.CorPelo = corpelo;
                        gato.DataNascimento = nascimento;
                        gato.Sexo = sexo;
                        gato.QtdeMamas = qtdemamas;
                        gato.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(gato);
                        break;
                   

                case "leao":
                  
                        Leao leao = new Leao(true, false, true);
                        leao.Nome = nome;
                        leao.CorPelo = corpelo;
                        leao.DataNascimento = nascimento;
                        leao.Sexo = sexo;
                        leao.QtdeMamas = qtdemamas;
                        leao.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(leao);
                        break;
                    

                case "morcego":
                   
                        Morcego morcego = new Morcego(false, false, true);
                        morcego.Nome = nome;
                        morcego.CorPelo = corpelo;
                        morcego.DataNascimento = nascimento;
                        morcego.Sexo = sexo;
                        morcego.QtdeMamas = qtdemamas;
                        morcego.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(morcego);
                        break;
                  

                case "ornitorrinco":
                   
                        Ornitorrinco ornitorrinco = new Ornitorrinco(true, false, true, true, true, true);
                        ornitorrinco.Nome = nome;
                        ornitorrinco.CorPelo = corpelo;
                        ornitorrinco.DataNascimento = nascimento;
                        ornitorrinco.Sexo = sexo;
                        ornitorrinco.QtdeMamas = qtdemamas;
                        ornitorrinco.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(ornitorrinco);
                        break;
                   
            }
        }

        /// <summary>
        /// Instanciar uma ave
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nome"></param>
        /// <param name="corpena"></param>
        /// <param name="nascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="altura"></param>
        /// <param name="velocidade"></param>
        public void InstanciaAve(string animal, string nome, string corpena, DateTime nascimento, char sexo, int altura, int velocidade)
        {
            switch (animal)
            {
                case "galinha":
                   
                        Galinha galinha = new Galinha(false, false, false);
                        galinha.Nome = nome;
                        galinha.CorPena = corpena;
                        galinha.DataNascimento = nascimento;
                        galinha.Sexo = sexo;
                        galinha.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(galinha);
                        break;
                  

                case "coruja":
                   
                        Coruja coruja = new Coruja(true, true, false);
                        coruja.Nome = nome;
                        coruja.CorPena = corpena;
                        coruja.DataNascimento = nascimento;
                        coruja.Sexo = sexo;
                        coruja.AlturaMaximaM = altura;
                        coruja.VelocidadeVoo = velocidade;
                        coruja.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(coruja);
                        break;
                   

                case "gaviao":
                  
                        Gaviao gaviao = new Gaviao(true, true, false);
                        gaviao.Nome = nome;
                        gaviao.CorPena = corpena;
                        gaviao.DataNascimento = nascimento;
                        gaviao.Sexo = sexo;
                        gaviao.AlturaMaximaM = altura;
                        gaviao.VelocidadeVoo = velocidade;
                        gaviao.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(gaviao);
                        break;
                  




                case "pato":
                   
                        Pato pato = new Pato(false, false, false, true, true, true);
                        pato.Nome = nome;
                        pato.CorPena = corpena;
                        pato.DataNascimento = nascimento;
                        pato.Sexo = sexo;
                        pato.AlturaMaximaM = altura;
                        pato.VelocidadeVoo = velocidade;
                        pato.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(pato);
                        break;
                


                case "pinguim":
                    
                        Pinguim pinguim = new Pinguim(true, false, false,true,true,false);
                        pinguim.Nome = nome;
                        pinguim.CorPena = corpena;
                        pinguim.DataNascimento = nascimento;
                        pinguim.Sexo = sexo;
                        pinguim.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(pinguim);
                        break;
                 


                case "pombo":
                  
                        Pombo pombo = new Pombo(false, false, false);
                        pombo.Nome = nome;
                        pombo.CorPena = corpena;
                        pombo.DataNascimento = nascimento;
                        pombo.Sexo = sexo;
                        pombo.AlturaMaximaM = altura;
                        pombo.VelocidadeVoo = velocidade;
                        pombo.Idade = nascimento.Year;
                        //Adicionar na árvore
                        ArvoreBinaria.Insere(pombo);
                        break;
                   

            }
        }

        /// <summary>
        /// Instanciar um Réptil
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nome"></param>
        /// <param name="nascimento"></param>
        /// <param name="sexo"></param>
        public void InstanciaReptil(string animal, string nome, DateTime nascimento, char sexo)
        {
                Tartaruga tartaruga = new Tartaruga(false, false, true, true, true, true, true);
                tartaruga.Nome = nome;
                tartaruga.DataNascimento = nascimento;
                tartaruga.Sexo = sexo;
                tartaruga.Idade = nascimento.Year;
                //Adicionar na árvore
                ArvoreBinaria.Insere(tartaruga);   
        }
        #endregion

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadAll_Click(object sender, EventArgs e)
        {
            Baleia baleia = new Baleia(false, true, false, false, true, false);
            baleia.Nome = "baleia";
            baleia.DataNascimento = DateTime.Parse("01/02/2001");
            baleia.Sexo = 'M';
            baleia.QtdeMamas = 6;
            baleia.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(baleia);

            Cachorro cachorro = new Cachorro(true, false, true);
            cachorro.Nome = "Cachorro";
            cachorro.CorPelo = "Marrom";
            cachorro.DataNascimento = DateTime.Parse("01/02/2001");
            cachorro.Sexo = 'M';
            cachorro.QtdeMamas = 6;
            cachorro.Idade = 2001;
            ArvoreBinaria.Insere(cachorro);


            Elefante elefante = new Elefante(false, false, true);
            elefante.Nome = "Elefante";
            elefante.CorPelo = "Cinza";
            elefante.DataNascimento = DateTime.Parse("01/02/2001");
            elefante.Sexo = 'F';
            elefante.QtdeMamas = 6;
            elefante.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(elefante);

            Gato gato = new Gato(true, false, true);
            gato.Nome = "Gato";
            gato.CorPelo = "Branco";
            gato.DataNascimento = DateTime.Parse("01/02/2001");
            gato.Sexo = 'M';
            gato.QtdeMamas = 6;
            gato.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(gato);

            Leao leao = new Leao(true, false, true);
            leao.Nome = "Leao";
            leao.CorPelo = "Amarelo";
            leao.DataNascimento = DateTime.Parse("01/02/2001");
            leao.Sexo = 'M';
            leao.QtdeMamas = 6;
            leao.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(leao);

            Morcego morcego = new Morcego(false, false, true);
            morcego.Nome = "Morcego";
            morcego.CorPelo = "Preto";
            morcego.DataNascimento = DateTime.Parse("01/02/2001");
            morcego.Sexo = 'M';
            morcego.QtdeMamas = 6;
            morcego.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(morcego);

            Ornitorrinco ornitorrinco = new Ornitorrinco(true, false, true, true, true, true);
            ornitorrinco.Nome = "Ornitorrinco";
            ornitorrinco.CorPelo = "Marrom";
            ornitorrinco.DataNascimento = DateTime.Parse("01/02/2001");
            ornitorrinco.Sexo = 'M';
            ornitorrinco.QtdeMamas = 6;
            ornitorrinco.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(ornitorrinco);


            Galinha galinha = new Galinha(false, false, false);
            galinha.Nome = "Galinha";
            galinha.CorPena =" Branco";
            galinha.DataNascimento = DateTime.Parse("01/02/2001");
            galinha.Sexo = 'F';
            galinha.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(galinha);

            Coruja coruja = new Coruja(true, true, false);
            coruja.Nome = "Coruja";
            coruja.CorPena = "marrom";
            coruja.DataNascimento = DateTime.Parse("01/02/2001");
            coruja.Sexo = 'M';
            coruja.AlturaMaximaM = 56;
            coruja.VelocidadeVoo = 89;
            coruja.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(coruja);

            Gaviao gaviao = new Gaviao(true, true, false);
            gaviao.Nome = "Gaviao";
            gaviao.CorPena = "branco";
            gaviao.DataNascimento = DateTime.Parse("01/02/2001");
            gaviao.Sexo = 'M';
            gaviao.AlturaMaximaM = 100;
            gaviao.VelocidadeVoo = 98;
            gaviao.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(gaviao);

            Pato pato = new Pato(false, false, false, true, true, true);
            pato.Nome = "Pato";
            pato.CorPena = "branco";
            pato.DataNascimento = DateTime.Parse("01/02/2001");
            pato.Sexo = 'M';
            pato.AlturaMaximaM = 30;
            pato.VelocidadeVoo = 60;
            pato.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(pato);

            Pinguim pinguim = new Pinguim(true, false, false, true, true, false);
            pinguim.Nome = "Pinguim";
            pinguim.CorPena = "preto";
            pinguim.DataNascimento = DateTime.Parse("01/02/2001");
            pinguim.Sexo = 'M';
            pinguim.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(pinguim);

            Pombo pombo = new Pombo(false, false, false);
            pombo.Nome = "Pomba";
            pombo.CorPena = "branco";
            pombo.DataNascimento = DateTime.Parse("01/02/2001");
            pombo.Sexo = 'M';
            pombo.AlturaMaximaM = 100;
            pombo.VelocidadeVoo = 80;
            pombo.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(pombo);

            Tartaruga tartaruga = new Tartaruga(false, false, true, true, true, true, true);
            tartaruga.Nome = "Tartaruga";
            tartaruga.DataNascimento = DateTime.Parse("01/02/2001");
            tartaruga.Sexo = 'F';
            tartaruga.Idade = 2001;
            //Adicionar na árvore
            ArvoreBinaria.Insere(tartaruga);

            btnCadAll.Enabled = false;
            MessageBox.Show("FEITO","CONCLUÍDO");
        }
    }
}
