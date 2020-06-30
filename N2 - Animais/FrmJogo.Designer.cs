namespace N2___Animais
{
    partial class FrmJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnTartaruga = new System.Windows.Forms.Button();
            this.btnPombo = new System.Windows.Forms.Button();
            this.btnPinguim = new System.Windows.Forms.Button();
            this.btnPato = new System.Windows.Forms.Button();
            this.btnOrnitorrinco = new System.Windows.Forms.Button();
            this.btnMorcego = new System.Windows.Forms.Button();
            this.btnLeao = new System.Windows.Forms.Button();
            this.btnGaviao = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            this.btnGalinha = new System.Windows.Forms.Button();
            this.btnElefante = new System.Windows.Forms.Button();
            this.btnCoruja = new System.Windows.Forms.Button();
            this.btnCachorro = new System.Windows.Forms.Button();
            this.btnBaleia = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnAmamentar = new System.Windows.Forms.Button();
            this.btnChocar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.btnCiscar = new System.Windows.Forms.Button();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.btnVoar = new System.Windows.Forms.Button();
            this.pctAnimal = new System.Windows.Forms.PictureBox();
            this.pnlFundoAcao = new System.Windows.Forms.Panel();
            this.lblComunica = new System.Windows.Forms.Label();
            this.txtCarac = new System.Windows.Forms.TextBox();
            this.cmbAnimais = new System.Windows.Forms.ComboBox();
            this.tmrApagalbl = new System.Windows.Forms.Timer(this.components);
            this.btnLiberaMov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimal)).BeginInit();
            this.pnlFundoAcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(48, 328);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(181, 104);
            this.btnCadastro.TabIndex = 15;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnTartaruga
            // 
            this.btnTartaruga.BackColor = System.Drawing.Color.LightYellow;
            this.btnTartaruga.BackgroundImage = global::N2___Animais.Properties.Resources.tartarugaapagada;
            this.btnTartaruga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTartaruga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTartaruga.Location = new System.Drawing.Point(1186, 724);
            this.btnTartaruga.Margin = new System.Windows.Forms.Padding(2);
            this.btnTartaruga.Name = "btnTartaruga";
            this.btnTartaruga.Size = new System.Drawing.Size(84, 68);
            this.btnTartaruga.TabIndex = 13;
            this.btnTartaruga.Tag = "tartaruga";
            this.btnTartaruga.UseVisualStyleBackColor = false;
            this.btnTartaruga.Click += new System.EventHandler(this.btnTartaruga_Click);
            this.btnTartaruga.MouseEnter += new System.EventHandler(this.btnTartaruga_MouseEnter);
            this.btnTartaruga.MouseLeave += new System.EventHandler(this.btnTartaruga_MouseLeave);
            // 
            // btnPombo
            // 
            this.btnPombo.BackColor = System.Drawing.Color.LightYellow;
            this.btnPombo.BackgroundImage = global::N2___Animais.Properties.Resources.pomboapagado;
            this.btnPombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPombo.Location = new System.Drawing.Point(1080, 724);
            this.btnPombo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPombo.Name = "btnPombo";
            this.btnPombo.Size = new System.Drawing.Size(84, 68);
            this.btnPombo.TabIndex = 12;
            this.btnPombo.Tag = "pombo";
            this.btnPombo.UseVisualStyleBackColor = false;
            this.btnPombo.Click += new System.EventHandler(this.btnPombo_Click);
            this.btnPombo.MouseEnter += new System.EventHandler(this.btnPombo_MouseEnter);
            this.btnPombo.MouseLeave += new System.EventHandler(this.btnPombo_MouseLeave);
            // 
            // btnPinguim
            // 
            this.btnPinguim.BackColor = System.Drawing.Color.LightYellow;
            this.btnPinguim.BackgroundImage = global::N2___Animais.Properties.Resources.pinguimapagado;
            this.btnPinguim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPinguim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPinguim.Location = new System.Drawing.Point(974, 724);
            this.btnPinguim.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinguim.Name = "btnPinguim";
            this.btnPinguim.Size = new System.Drawing.Size(84, 68);
            this.btnPinguim.TabIndex = 11;
            this.btnPinguim.Tag = "pinguim";
            this.btnPinguim.UseVisualStyleBackColor = false;
            this.btnPinguim.Click += new System.EventHandler(this.btnPinguim_Click);
            this.btnPinguim.MouseEnter += new System.EventHandler(this.btnPinguim_MouseEnter);
            this.btnPinguim.MouseLeave += new System.EventHandler(this.btnPinguim_MouseLeave);
            // 
            // btnPato
            // 
            this.btnPato.BackColor = System.Drawing.Color.LightYellow;
            this.btnPato.BackgroundImage = global::N2___Animais.Properties.Resources.patoapagado;
            this.btnPato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPato.Location = new System.Drawing.Point(868, 724);
            this.btnPato.Margin = new System.Windows.Forms.Padding(2);
            this.btnPato.Name = "btnPato";
            this.btnPato.Size = new System.Drawing.Size(84, 68);
            this.btnPato.TabIndex = 10;
            this.btnPato.Tag = "pato";
            this.btnPato.UseVisualStyleBackColor = false;
            this.btnPato.Click += new System.EventHandler(this.btnPato_Click);
            this.btnPato.MouseEnter += new System.EventHandler(this.btnPato_MouseEnter);
            this.btnPato.MouseLeave += new System.EventHandler(this.btnPato_MouseLeave);
            // 
            // btnOrnitorrinco
            // 
            this.btnOrnitorrinco.BackColor = System.Drawing.Color.LightYellow;
            this.btnOrnitorrinco.BackgroundImage = global::N2___Animais.Properties.Resources.ornitorrincoapagado;
            this.btnOrnitorrinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrnitorrinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrnitorrinco.Location = new System.Drawing.Point(762, 724);
            this.btnOrnitorrinco.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnitorrinco.Name = "btnOrnitorrinco";
            this.btnOrnitorrinco.Size = new System.Drawing.Size(84, 68);
            this.btnOrnitorrinco.TabIndex = 9;
            this.btnOrnitorrinco.Tag = "ornitorrinco";
            this.btnOrnitorrinco.UseVisualStyleBackColor = false;
            this.btnOrnitorrinco.Click += new System.EventHandler(this.btnOrnitorrinco_Click);
            this.btnOrnitorrinco.MouseEnter += new System.EventHandler(this.btnOrnitorrinco_MouseEnter);
            this.btnOrnitorrinco.MouseLeave += new System.EventHandler(this.btnOrnitorrinco_MouseLeave);
            // 
            // btnMorcego
            // 
            this.btnMorcego.BackColor = System.Drawing.Color.LightYellow;
            this.btnMorcego.BackgroundImage = global::N2___Animais.Properties.Resources.morcegoapagado;
            this.btnMorcego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMorcego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMorcego.Location = new System.Drawing.Point(656, 724);
            this.btnMorcego.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorcego.Name = "btnMorcego";
            this.btnMorcego.Size = new System.Drawing.Size(84, 68);
            this.btnMorcego.TabIndex = 8;
            this.btnMorcego.Tag = "morcego";
            this.btnMorcego.UseVisualStyleBackColor = false;
            this.btnMorcego.Click += new System.EventHandler(this.btnMorcego_Click);
            this.btnMorcego.MouseEnter += new System.EventHandler(this.btnMorcego_MouseEnter);
            this.btnMorcego.MouseLeave += new System.EventHandler(this.btnMorcego_MouseLeave);
            // 
            // btnLeao
            // 
            this.btnLeao.BackColor = System.Drawing.Color.LightYellow;
            this.btnLeao.BackgroundImage = global::N2___Animais.Properties.Resources.leaoapagado;
            this.btnLeao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeao.Location = new System.Drawing.Point(550, 724);
            this.btnLeao.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeao.Name = "btnLeao";
            this.btnLeao.Size = new System.Drawing.Size(84, 68);
            this.btnLeao.TabIndex = 7;
            this.btnLeao.Tag = "leao";
            this.btnLeao.UseVisualStyleBackColor = false;
            this.btnLeao.Click += new System.EventHandler(this.btnLeao_Click);
            this.btnLeao.MouseEnter += new System.EventHandler(this.btnLeao_MouseEnter);
            this.btnLeao.MouseLeave += new System.EventHandler(this.btnLeao_MouseLeave);
            // 
            // btnGaviao
            // 
            this.btnGaviao.BackColor = System.Drawing.Color.LightYellow;
            this.btnGaviao.BackgroundImage = global::N2___Animais.Properties.Resources.gaviaoapagado;
            this.btnGaviao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGaviao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGaviao.Location = new System.Drawing.Point(1186, 639);
            this.btnGaviao.Margin = new System.Windows.Forms.Padding(2);
            this.btnGaviao.Name = "btnGaviao";
            this.btnGaviao.Size = new System.Drawing.Size(84, 68);
            this.btnGaviao.TabIndex = 6;
            this.btnGaviao.Tag = "gaviao";
            this.btnGaviao.UseVisualStyleBackColor = false;
            this.btnGaviao.Click += new System.EventHandler(this.btnGaviao_Click);
            this.btnGaviao.MouseEnter += new System.EventHandler(this.btnGaviao_MouseEnter);
            this.btnGaviao.MouseLeave += new System.EventHandler(this.btnGaviao_MouseLeave);
            // 
            // btnGato
            // 
            this.btnGato.BackColor = System.Drawing.Color.LightYellow;
            this.btnGato.BackgroundImage = global::N2___Animais.Properties.Resources.gatoapagado;
            this.btnGato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGato.Location = new System.Drawing.Point(1080, 639);
            this.btnGato.Margin = new System.Windows.Forms.Padding(2);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(84, 68);
            this.btnGato.TabIndex = 5;
            this.btnGato.Tag = "gato";
            this.btnGato.UseVisualStyleBackColor = false;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            this.btnGato.MouseEnter += new System.EventHandler(this.btnGato_MouseEnter);
            this.btnGato.MouseLeave += new System.EventHandler(this.btnGato_MouseLeave);
            // 
            // btnGalinha
            // 
            this.btnGalinha.BackColor = System.Drawing.Color.LightYellow;
            this.btnGalinha.BackgroundImage = global::N2___Animais.Properties.Resources.galinhaapagada;
            this.btnGalinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGalinha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGalinha.Location = new System.Drawing.Point(974, 639);
            this.btnGalinha.Margin = new System.Windows.Forms.Padding(2);
            this.btnGalinha.Name = "btnGalinha";
            this.btnGalinha.Size = new System.Drawing.Size(84, 68);
            this.btnGalinha.TabIndex = 4;
            this.btnGalinha.Tag = "galinha";
            this.btnGalinha.UseVisualStyleBackColor = false;
            this.btnGalinha.Click += new System.EventHandler(this.btnGalinha_Click);
            this.btnGalinha.MouseEnter += new System.EventHandler(this.btnGalinha_MouseEnter);
            this.btnGalinha.MouseLeave += new System.EventHandler(this.btnGalinha_MouseLeave);
            // 
            // btnElefante
            // 
            this.btnElefante.BackColor = System.Drawing.Color.LightYellow;
            this.btnElefante.BackgroundImage = global::N2___Animais.Properties.Resources.elefanteapagado;
            this.btnElefante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElefante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElefante.Location = new System.Drawing.Point(868, 639);
            this.btnElefante.Margin = new System.Windows.Forms.Padding(2);
            this.btnElefante.Name = "btnElefante";
            this.btnElefante.Size = new System.Drawing.Size(84, 68);
            this.btnElefante.TabIndex = 3;
            this.btnElefante.Tag = "elefante";
            this.btnElefante.UseVisualStyleBackColor = false;
            this.btnElefante.Click += new System.EventHandler(this.btnElefante_Click);
            this.btnElefante.MouseEnter += new System.EventHandler(this.btnElefante_MouseEnter);
            this.btnElefante.MouseLeave += new System.EventHandler(this.btnElefante_MouseLeave);
            // 
            // btnCoruja
            // 
            this.btnCoruja.BackColor = System.Drawing.Color.LightYellow;
            this.btnCoruja.BackgroundImage = global::N2___Animais.Properties.Resources.corujaapagada;
            this.btnCoruja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoruja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoruja.Location = new System.Drawing.Point(762, 639);
            this.btnCoruja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoruja.Name = "btnCoruja";
            this.btnCoruja.Size = new System.Drawing.Size(84, 68);
            this.btnCoruja.TabIndex = 2;
            this.btnCoruja.Tag = "coruja";
            this.btnCoruja.UseVisualStyleBackColor = false;
            this.btnCoruja.Click += new System.EventHandler(this.btnCoruja_Click);
            this.btnCoruja.MouseEnter += new System.EventHandler(this.btnCoruja_MouseEnter);
            this.btnCoruja.MouseLeave += new System.EventHandler(this.btnCoruja_MouseLeave);
            // 
            // btnCachorro
            // 
            this.btnCachorro.BackColor = System.Drawing.Color.LightYellow;
            this.btnCachorro.BackgroundImage = global::N2___Animais.Properties.Resources.cachorroapagado;
            this.btnCachorro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCachorro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCachorro.Location = new System.Drawing.Point(656, 639);
            this.btnCachorro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCachorro.Name = "btnCachorro";
            this.btnCachorro.Size = new System.Drawing.Size(84, 68);
            this.btnCachorro.TabIndex = 1;
            this.btnCachorro.Tag = "cachorro";
            this.btnCachorro.UseVisualStyleBackColor = false;
            this.btnCachorro.Click += new System.EventHandler(this.btnCachorro_Click);
            this.btnCachorro.MouseEnter += new System.EventHandler(this.btnCachorro_MouseEnter);
            this.btnCachorro.MouseLeave += new System.EventHandler(this.btnCachorro_MouseLeave);
            // 
            // btnBaleia
            // 
            this.btnBaleia.BackColor = System.Drawing.Color.LightYellow;
            this.btnBaleia.BackgroundImage = global::N2___Animais.Properties.Resources.baleiaapagada;
            this.btnBaleia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaleia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaleia.Location = new System.Drawing.Point(550, 639);
            this.btnBaleia.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaleia.Name = "btnBaleia";
            this.btnBaleia.Size = new System.Drawing.Size(84, 68);
            this.btnBaleia.TabIndex = 0;
            this.btnBaleia.Tag = "baleia";
            this.btnBaleia.UseVisualStyleBackColor = false;
            this.btnBaleia.Click += new System.EventHandler(this.btnBaleia_Click);
            this.btnBaleia.MouseEnter += new System.EventHandler(this.btnBaleia_MouseEnter);
            this.btnBaleia.MouseLeave += new System.EventHandler(this.btnBaleia_MouseLeave);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Transparent;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(299, 328);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(181, 104);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.BackColor = System.Drawing.Color.Transparent;
            this.btnMovimentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovimentar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentar.ForeColor = System.Drawing.Color.White;
            this.btnMovimentar.Location = new System.Drawing.Point(6, 506);
            this.btnMovimentar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(162, 70);
            this.btnMovimentar.TabIndex = 17;
            this.btnMovimentar.Tag = "movimentar";
            this.btnMovimentar.Text = "MOVIMENTAR";
            this.btnMovimentar.UseVisualStyleBackColor = false;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnComunicar
            // 
            this.btnComunicar.BackColor = System.Drawing.Color.Transparent;
            this.btnComunicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComunicar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunicar.ForeColor = System.Drawing.Color.White;
            this.btnComunicar.Location = new System.Drawing.Point(189, 505);
            this.btnComunicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComunicar.Name = "btnComunicar";
            this.btnComunicar.Size = new System.Drawing.Size(146, 70);
            this.btnComunicar.TabIndex = 18;
            this.btnComunicar.Tag = "comunicar";
            this.btnComunicar.Text = "COMUNICAR";
            this.btnComunicar.UseVisualStyleBackColor = false;
            this.btnComunicar.Click += new System.EventHandler(this.btnComunicar_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlimentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlimentar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentar.ForeColor = System.Drawing.Color.White;
            this.btnAlimentar.Location = new System.Drawing.Point(360, 506);
            this.btnAlimentar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(146, 70);
            this.btnAlimentar.TabIndex = 19;
            this.btnAlimentar.Tag = "alimentar";
            this.btnAlimentar.Text = "ALIMENTAR";
            this.btnAlimentar.UseVisualStyleBackColor = false;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnAmamentar
            // 
            this.btnAmamentar.BackColor = System.Drawing.Color.Transparent;
            this.btnAmamentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmamentar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAmamentar.ForeColor = System.Drawing.Color.White;
            this.btnAmamentar.Location = new System.Drawing.Point(12, 614);
            this.btnAmamentar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmamentar.Name = "btnAmamentar";
            this.btnAmamentar.Size = new System.Drawing.Size(156, 70);
            this.btnAmamentar.TabIndex = 20;
            this.btnAmamentar.Text = "AMAMENTAR";
            this.btnAmamentar.UseVisualStyleBackColor = false;
            this.btnAmamentar.Click += new System.EventHandler(this.btnAmamentar_Click);
            // 
            // btnChocar
            // 
            this.btnChocar.BackColor = System.Drawing.Color.Transparent;
            this.btnChocar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChocar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChocar.ForeColor = System.Drawing.Color.White;
            this.btnChocar.Location = new System.Drawing.Point(12, 729);
            this.btnChocar.Margin = new System.Windows.Forms.Padding(2);
            this.btnChocar.Name = "btnChocar";
            this.btnChocar.Size = new System.Drawing.Size(146, 70);
            this.btnChocar.TabIndex = 21;
            this.btnChocar.Text = "CHOCAR";
            this.btnChocar.UseVisualStyleBackColor = false;
            this.btnChocar.Click += new System.EventHandler(this.btnChocar_Click);
            // 
            // btnBotar
            // 
            this.btnBotar.BackColor = System.Drawing.Color.Transparent;
            this.btnBotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBotar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotar.ForeColor = System.Drawing.Color.White;
            this.btnBotar.Location = new System.Drawing.Point(359, 616);
            this.btnBotar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBotar.Name = "btnBotar";
            this.btnBotar.Size = new System.Drawing.Size(146, 70);
            this.btnBotar.TabIndex = 22;
            this.btnBotar.Text = "BOTAR";
            this.btnBotar.UseVisualStyleBackColor = false;
            this.btnBotar.Click += new System.EventHandler(this.btnBotar_Click);
            // 
            // btnCiscar
            // 
            this.btnCiscar.BackColor = System.Drawing.Color.Transparent;
            this.btnCiscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCiscar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiscar.ForeColor = System.Drawing.Color.White;
            this.btnCiscar.Location = new System.Drawing.Point(187, 614);
            this.btnCiscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiscar.Name = "btnCiscar";
            this.btnCiscar.Size = new System.Drawing.Size(146, 70);
            this.btnCiscar.TabIndex = 23;
            this.btnCiscar.Text = "CISCAR";
            this.btnCiscar.UseVisualStyleBackColor = false;
            this.btnCiscar.Click += new System.EventHandler(this.btnCiscar_Click);
            // 
            // btnAtaque
            // 
            this.btnAtaque.BackColor = System.Drawing.Color.Transparent;
            this.btnAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaque.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque.ForeColor = System.Drawing.Color.White;
            this.btnAtaque.Location = new System.Drawing.Point(358, 729);
            this.btnAtaque.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(146, 70);
            this.btnAtaque.TabIndex = 24;
            this.btnAtaque.Tag = "ataque";
            this.btnAtaque.Text = "ATAQUE";
            this.btnAtaque.UseVisualStyleBackColor = false;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnVoar
            // 
            this.btnVoar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoar.ForeColor = System.Drawing.Color.White;
            this.btnVoar.Location = new System.Drawing.Point(187, 729);
            this.btnVoar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(146, 70);
            this.btnVoar.TabIndex = 25;
            this.btnVoar.Text = "VOAR";
            this.btnVoar.UseVisualStyleBackColor = false;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // pctAnimal
            // 
            this.pctAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctAnimal.Location = new System.Drawing.Point(33, 238);
            this.pctAnimal.Name = "pctAnimal";
            this.pctAnimal.Size = new System.Drawing.Size(157, 147);
            this.pctAnimal.TabIndex = 0;
            this.pctAnimal.TabStop = false;
            // 
            // pnlFundoAcao
            // 
            this.pnlFundoAcao.BackColor = System.Drawing.Color.Transparent;
            this.pnlFundoAcao.BackgroundImage = global::N2___Animais.Properties.Resources.gramado;
            this.pnlFundoAcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFundoAcao.Controls.Add(this.lblComunica);
            this.pnlFundoAcao.Controls.Add(this.txtCarac);
            this.pnlFundoAcao.Controls.Add(this.pctAnimal);
            this.pnlFundoAcao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlFundoAcao.Location = new System.Drawing.Point(550, 9);
            this.pnlFundoAcao.Name = "pnlFundoAcao";
            this.pnlFundoAcao.Size = new System.Drawing.Size(720, 551);
            this.pnlFundoAcao.TabIndex = 14;
            // 
            // lblComunica
            // 
            this.lblComunica.AutoSize = true;
            this.lblComunica.BackColor = System.Drawing.Color.Transparent;
            this.lblComunica.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunica.Location = new System.Drawing.Point(30, 23);
            this.lblComunica.Name = "lblComunica";
            this.lblComunica.Size = new System.Drawing.Size(18, 29);
            this.lblComunica.TabIndex = 5;
            this.lblComunica.Text = ".";
            // 
            // txtCarac
            // 
            this.txtCarac.BackColor = System.Drawing.Color.White;
            this.txtCarac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarac.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarac.Location = new System.Drawing.Point(4, 498);
            this.txtCarac.Multiline = true;
            this.txtCarac.Name = "txtCarac";
            this.txtCarac.Size = new System.Drawing.Size(711, 48);
            this.txtCarac.TabIndex = 4;
            // 
            // cmbAnimais
            // 
            this.cmbAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimais.FormattingEnabled = true;
            this.cmbAnimais.Location = new System.Drawing.Point(1065, 576);
            this.cmbAnimais.Name = "cmbAnimais";
            this.cmbAnimais.Size = new System.Drawing.Size(190, 24);
            this.cmbAnimais.TabIndex = 26;
            this.cmbAnimais.SelectedIndexChanged += new System.EventHandler(this.cmbAnimais_SelectedIndexChanged);
            // 
            // tmrApagalbl
            // 
            this.tmrApagalbl.Interval = 4000;
            this.tmrApagalbl.Tick += new System.EventHandler(this.tmrApagalbl_Tick);
            // 
            // btnLiberaMov
            // 
            this.btnLiberaMov.BackColor = System.Drawing.Color.Transparent;
            this.btnLiberaMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLiberaMov.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberaMov.ForeColor = System.Drawing.Color.White;
            this.btnLiberaMov.Location = new System.Drawing.Point(12, 461);
            this.btnLiberaMov.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiberaMov.Name = "btnLiberaMov";
            this.btnLiberaMov.Size = new System.Drawing.Size(156, 37);
            this.btnLiberaMov.TabIndex = 27;
            this.btnLiberaMov.Tag = "movimentar";
            this.btnLiberaMov.Text = "LIBERAR";
            this.btnLiberaMov.UseVisualStyleBackColor = false;
            this.btnLiberaMov.Click += new System.EventHandler(this.btnLiberaMov_Click);
            // 
            // FrmJogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::N2___Animais.Properties.Resources.Fundo_form_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 833);
            this.Controls.Add(this.btnLiberaMov);
            this.Controls.Add(this.cmbAnimais);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.btnCiscar);
            this.Controls.Add(this.btnBotar);
            this.Controls.Add(this.btnChocar);
            this.Controls.Add(this.btnAmamentar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnComunicar);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pnlFundoAcao);
            this.Controls.Add(this.btnTartaruga);
            this.Controls.Add(this.btnPombo);
            this.Controls.Add(this.btnPinguim);
            this.Controls.Add(this.btnPato);
            this.Controls.Add(this.btnOrnitorrinco);
            this.Controls.Add(this.btnMorcego);
            this.Controls.Add(this.btnLeao);
            this.Controls.Add(this.btnGaviao);
            this.Controls.Add(this.btnGato);
            this.Controls.Add(this.btnGalinha);
            this.Controls.Add(this.btnElefante);
            this.Controls.Add(this.btnCoruja);
            this.Controls.Add(this.btnCachorro);
            this.Controls.Add(this.btnBaleia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1281, 749);
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANIMAL KINGDOM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimal)).EndInit();
            this.pnlFundoAcao.ResumeLayout(false);
            this.pnlFundoAcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaleia;
        private System.Windows.Forms.Button btnCachorro;
        private System.Windows.Forms.Button btnCoruja;
        private System.Windows.Forms.Button btnElefante;
        private System.Windows.Forms.Button btnGalinha;
        private System.Windows.Forms.Button btnGato;
        private System.Windows.Forms.Button btnGaviao;
        private System.Windows.Forms.Button btnLeao;
        private System.Windows.Forms.Button btnMorcego;
        private System.Windows.Forms.Button btnOrnitorrinco;
        private System.Windows.Forms.Button btnPato;
        private System.Windows.Forms.Button btnPinguim;
        private System.Windows.Forms.Button btnPombo;
        private System.Windows.Forms.Button btnTartaruga;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnAmamentar;
        private System.Windows.Forms.Button btnChocar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.Button btnCiscar;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.PictureBox pctAnimal;
        private System.Windows.Forms.Panel pnlFundoAcao;
        private System.Windows.Forms.TextBox txtCarac;
        private System.Windows.Forms.ComboBox cmbAnimais;
        private System.Windows.Forms.Label lblComunica;
        private System.Windows.Forms.Timer tmrApagalbl;
        private System.Windows.Forms.Button btnLiberaMov;
    }
}

