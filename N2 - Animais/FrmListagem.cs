using System;
using N2___Animais.ANIMAIS;
using N2___Animais.ESTRUTURA_DADOS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    public partial class FrmListagem : Form
    {
        public FrmListagem()
        {
            InitializeComponent();
        }

        
        Lista listar = new Lista();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region BOTÕES DE LISTAGEM
        private void BtnListarAnimais_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarGeral();
        }

        private void BtnListarMamiferos_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarMamifero();
        }

        private void BtnListarOviparos_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarOviparo();
        }

        private void BtnListarPredadores_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarPredadores();
        }

        private void BtnListarAnimaisAquaticos_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarAquaticos();
        }

        private void BtnListarAnimaisQueVoam_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarAnimaisVoam();
        }

        private void BtnLIstarPorIdade_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarIdade();
        }

        private void BtnListarOrdemAlfabetica_Click(object sender, EventArgs e)
        {
            textBox1.Text = ArvoreBinaria.ListagemInterfixada().ListarGeral();
        }
        #endregion

        //listar = ArvoreBinaria.ListagemInterfixada();
        //textBox1.Text = ArvoreBinaria.ListagemInterfixada().Listar();

    }
}
