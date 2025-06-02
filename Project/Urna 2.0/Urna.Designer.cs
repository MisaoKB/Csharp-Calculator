namespace Urna_2._0
{
    partial class jnl_urna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jnl_urna));
            this.btn_branco = new System.Windows.Forms.Button();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.btn_corrige = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.lab_digito1 = new System.Windows.Forms.Label();
            this.lab_numero = new System.Windows.Forms.Label();
            this.lab_digito2 = new System.Windows.Forms.Label();
            this.lab_cargo = new System.Windows.Forms.Label();
            this.lab_nome_presidente = new System.Windows.Forms.Label();
            this.img_presidente = new System.Windows.Forms.PictureBox();
            this.lab_presidente_imagem = new System.Windows.Forms.Label();
            this.lab_seu_voto = new System.Windows.Forms.Label();
            this.lab_partido = new System.Windows.Forms.Label();
            this.lab_nome = new System.Windows.Forms.Label();
            this.lab_vice = new System.Windows.Forms.Label();
            this.lab_partido_presidente = new System.Windows.Forms.Label();
            this.lab_vice_presidente = new System.Windows.Forms.Label();
            this.lab_vice_imagem = new System.Windows.Forms.Label();
            this.img_vice = new System.Windows.Forms.PictureBox();
            this.lab_aviso = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_presidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_vice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_branco
            // 
            this.btn_branco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_branco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_branco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_branco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_branco.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_branco.Location = new System.Drawing.Point(666, 433);
            this.btn_branco.Margin = new System.Windows.Forms.Padding(2);
            this.btn_branco.Name = "btn_branco";
            this.btn_branco.Size = new System.Drawing.Size(73, 38);
            this.btn_branco.TabIndex = 2;
            this.btn_branco.Tag = "validar";
            this.btn_branco.Text = "BRANCO";
            this.btn_branco.UseVisualStyleBackColor = false;
            this.btn_branco.Click += new System.EventHandler(this.voto_branco);
            // 
            // btn_confirma
            // 
            this.btn_confirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.btn_confirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirma.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_confirma.Location = new System.Drawing.Point(833, 433);
            this.btn_confirma.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(73, 38);
            this.btn_confirma.TabIndex = 0;
            this.btn_confirma.Tag = "validar";
            this.btn_confirma.Text = "CONFIRMA";
            this.btn_confirma.UseVisualStyleBackColor = false;
            this.btn_confirma.Click += new System.EventHandler(this.confirmar_voto);
            // 
            // btn_corrige
            // 
            this.btn_corrige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_corrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_corrige.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_corrige.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_corrige.Font = new System.Drawing.Font("Roboto Black", 6.75F, System.Drawing.FontStyle.Bold);
            this.btn_corrige.Location = new System.Drawing.Point(759, 438);
            this.btn_corrige.Margin = new System.Windows.Forms.Padding(2);
            this.btn_corrige.Name = "btn_corrige";
            this.btn_corrige.Size = new System.Drawing.Size(55, 29);
            this.btn_corrige.TabIndex = 1;
            this.btn_corrige.Tag = "validar";
            this.btn_corrige.Text = "CORRIGE";
            this.btn_corrige.UseVisualStyleBackColor = false;
            this.btn_corrige.Click += new System.EventHandler(this.btn_corrige_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_1.Location = new System.Drawing.Point(666, 91);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 33);
            this.btn_1.TabIndex = 3;
            this.btn_1.Tag = "botões_digitos";
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_2.Location = new System.Drawing.Point(754, 91);
            this.btn_2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 33);
            this.btn_2.TabIndex = 4;
            this.btn_2.Tag = "botões_digitos";
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_3.Location = new System.Drawing.Point(841, 91);
            this.btn_3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 33);
            this.btn_3.TabIndex = 5;
            this.btn_3.Tag = "botões_digitos";
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_6.Location = new System.Drawing.Point(841, 173);
            this.btn_6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 33);
            this.btn_6.TabIndex = 8;
            this.btn_6.Tag = "botões_digitos";
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_5.Location = new System.Drawing.Point(754, 173);
            this.btn_5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 33);
            this.btn_5.TabIndex = 7;
            this.btn_5.Tag = "botões_digitos";
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_4.Location = new System.Drawing.Point(666, 173);
            this.btn_4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 33);
            this.btn_4.TabIndex = 6;
            this.btn_4.Tag = "botões_digitos";
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_9.Location = new System.Drawing.Point(841, 255);
            this.btn_9.Margin = new System.Windows.Forms.Padding(2);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 33);
            this.btn_9.TabIndex = 11;
            this.btn_9.Tag = "botões_digitos";
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_8.Location = new System.Drawing.Point(754, 255);
            this.btn_8.Margin = new System.Windows.Forms.Padding(2);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 33);
            this.btn_8.TabIndex = 10;
            this.btn_8.Tag = "botões_digitos";
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_7.Location = new System.Drawing.Point(666, 255);
            this.btn_7.Margin = new System.Windows.Forms.Padding(2);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 33);
            this.btn_7.TabIndex = 9;
            this.btn_7.Tag = "botões_digitos";
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_digitos);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(31)))));
            this.btn_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_0.Location = new System.Drawing.Point(754, 336);
            this.btn_0.Margin = new System.Windows.Forms.Padding(2);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(65, 33);
            this.btn_0.TabIndex = 12;
            this.btn_0.Tag = "botões_digitos";
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_digitos);
            // 
            // lab_digito1
            // 
            this.lab_digito1.AutoSize = true;
            this.lab_digito1.BackColor = System.Drawing.Color.White;
            this.lab_digito1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_digito1.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.lab_digito1.Location = new System.Drawing.Point(195, 149);
            this.lab_digito1.MaximumSize = new System.Drawing.Size(32, 35);
            this.lab_digito1.MinimumSize = new System.Drawing.Size(32, 35);
            this.lab_digito1.Name = "lab_digito1";
            this.lab_digito1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lab_digito1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_digito1.Size = new System.Drawing.Size(32, 35);
            this.lab_digito1.TabIndex = 13;
            this.lab_digito1.Tag = "info_candidato";
            this.lab_digito1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_numero
            // 
            this.lab_numero.AutoSize = true;
            this.lab_numero.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_numero.Location = new System.Drawing.Point(44, 152);
            this.lab_numero.Name = "lab_numero";
            this.lab_numero.Size = new System.Drawing.Size(105, 29);
            this.lab_numero.TabIndex = 14;
            this.lab_numero.Tag = "info_candidato";
            this.lab_numero.Text = "Número:";
            this.lab_numero.Visible = false;
            // 
            // lab_digito2
            // 
            this.lab_digito2.AutoSize = true;
            this.lab_digito2.BackColor = System.Drawing.Color.White;
            this.lab_digito2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_digito2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.lab_digito2.Location = new System.Drawing.Point(161, 149);
            this.lab_digito2.MaximumSize = new System.Drawing.Size(32, 35);
            this.lab_digito2.MinimumSize = new System.Drawing.Size(32, 35);
            this.lab_digito2.Name = "lab_digito2";
            this.lab_digito2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lab_digito2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_digito2.Size = new System.Drawing.Size(32, 35);
            this.lab_digito2.TabIndex = 15;
            this.lab_digito2.Tag = "info_candidato";
            this.lab_digito2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_cargo
            // 
            this.lab_cargo.AutoSize = true;
            this.lab_cargo.Font = new System.Drawing.Font("Roboto", 16F);
            this.lab_cargo.Location = new System.Drawing.Point(191, 71);
            this.lab_cargo.Name = "lab_cargo";
            this.lab_cargo.Size = new System.Drawing.Size(141, 27);
            this.lab_cargo.TabIndex = 17;
            this.lab_cargo.Tag = "info_candidato";
            this.lab_cargo.Text = "PRESIDENTE";
            // 
            // lab_nome_presidente
            // 
            this.lab_nome_presidente.AutoSize = true;
            this.lab_nome_presidente.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nome_presidente.Location = new System.Drawing.Point(155, 222);
            this.lab_nome_presidente.MaximumSize = new System.Drawing.Size(309, 33);
            this.lab_nome_presidente.Name = "lab_nome_presidente";
            this.lab_nome_presidente.Size = new System.Drawing.Size(0, 33);
            this.lab_nome_presidente.TabIndex = 19;
            this.lab_nome_presidente.Tag = "info_candidato";
            this.lab_nome_presidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_nome_presidente.Visible = false;
            // 
            // img_presidente
            // 
            this.img_presidente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_presidente.Location = new System.Drawing.Point(468, 91);
            this.img_presidente.Name = "img_presidente";
            this.img_presidente.Size = new System.Drawing.Size(128, 128);
            this.img_presidente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_presidente.TabIndex = 24;
            this.img_presidente.TabStop = false;
            this.img_presidente.Tag = "info_candidato";
            this.img_presidente.Visible = false;
            // 
            // lab_presidente_imagem
            // 
            this.lab_presidente_imagem.AutoSize = true;
            this.lab_presidente_imagem.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_presidente_imagem.Location = new System.Drawing.Point(468, 236);
            this.lab_presidente_imagem.MaximumSize = new System.Drawing.Size(133, 15);
            this.lab_presidente_imagem.Name = "lab_presidente_imagem";
            this.lab_presidente_imagem.Size = new System.Drawing.Size(0, 15);
            this.lab_presidente_imagem.TabIndex = 26;
            this.lab_presidente_imagem.Tag = "info_candidato";
            this.lab_presidente_imagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_presidente_imagem.Visible = false;
            // 
            // lab_seu_voto
            // 
            this.lab_seu_voto.AutoSize = true;
            this.lab_seu_voto.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lab_seu_voto.Location = new System.Drawing.Point(46, 76);
            this.lab_seu_voto.Name = "lab_seu_voto";
            this.lab_seu_voto.Size = new System.Drawing.Size(124, 17);
            this.lab_seu_voto.TabIndex = 16;
            this.lab_seu_voto.Tag = "info_candidato";
            this.lab_seu_voto.Text = "SEU VOTO PARA";
            this.lab_seu_voto.Visible = false;
            // 
            // lab_partido
            // 
            this.lab_partido.AutoSize = true;
            this.lab_partido.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_partido.Location = new System.Drawing.Point(44, 296);
            this.lab_partido.Name = "lab_partido";
            this.lab_partido.Size = new System.Drawing.Size(98, 29);
            this.lab_partido.TabIndex = 28;
            this.lab_partido.Tag = "info_candidato";
            this.lab_partido.Text = "Partido:";
            this.lab_partido.Visible = false;
            // 
            // lab_nome
            // 
            this.lab_nome.AutoSize = true;
            this.lab_nome.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nome.Location = new System.Drawing.Point(44, 224);
            this.lab_nome.Name = "lab_nome";
            this.lab_nome.Size = new System.Drawing.Size(84, 29);
            this.lab_nome.TabIndex = 29;
            this.lab_nome.Tag = "info_candidato";
            this.lab_nome.Text = "Nome:";
            this.lab_nome.Visible = false;
            // 
            // lab_vice
            // 
            this.lab_vice.AutoSize = true;
            this.lab_vice.Font = new System.Drawing.Font("Roboto", 14F);
            this.lab_vice.Location = new System.Drawing.Point(66, 363);
            this.lab_vice.Name = "lab_vice";
            this.lab_vice.Size = new System.Drawing.Size(146, 23);
            this.lab_vice.TabIndex = 30;
            this.lab_vice.Tag = "info_candidato";
            this.lab_vice.Text = "Vice-presidente:";
            this.lab_vice.Visible = false;
            // 
            // lab_partido_presidente
            // 
            this.lab_partido_presidente.AutoSize = true;
            this.lab_partido_presidente.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_partido_presidente.Location = new System.Drawing.Point(155, 294);
            this.lab_partido_presidente.MaximumSize = new System.Drawing.Size(347, 33);
            this.lab_partido_presidente.Name = "lab_partido_presidente";
            this.lab_partido_presidente.Size = new System.Drawing.Size(0, 33);
            this.lab_partido_presidente.TabIndex = 31;
            this.lab_partido_presidente.Tag = "info_candidato";
            this.lab_partido_presidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_partido_presidente.Visible = false;
            // 
            // lab_vice_presidente
            // 
            this.lab_vice_presidente.AutoSize = true;
            this.lab_vice_presidente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
            this.lab_vice_presidente.Location = new System.Drawing.Point(219, 361);
            this.lab_vice_presidente.MaximumSize = new System.Drawing.Size(276, 27);
            this.lab_vice_presidente.Name = "lab_vice_presidente";
            this.lab_vice_presidente.Size = new System.Drawing.Size(0, 27);
            this.lab_vice_presidente.TabIndex = 32;
            this.lab_vice_presidente.Tag = "info_candidato";
            this.lab_vice_presidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_vice_presidente.Visible = false;
            // 
            // lab_vice_imagem
            // 
            this.lab_vice_imagem.AutoSize = true;
            this.lab_vice_imagem.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_vice_imagem.Location = new System.Drawing.Point(503, 407);
            this.lab_vice_imagem.MaximumSize = new System.Drawing.Size(98, 15);
            this.lab_vice_imagem.Name = "lab_vice_imagem";
            this.lab_vice_imagem.Size = new System.Drawing.Size(0, 15);
            this.lab_vice_imagem.TabIndex = 34;
            this.lab_vice_imagem.Tag = "info_candidato";
            this.lab_vice_imagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_vice_imagem.Visible = false;
            // 
            // img_vice
            // 
            this.img_vice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_vice.Location = new System.Drawing.Point(503, 297);
            this.img_vice.Name = "img_vice";
            this.img_vice.Size = new System.Drawing.Size(96, 96);
            this.img_vice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_vice.TabIndex = 33;
            this.img_vice.TabStop = false;
            this.img_vice.Tag = "info_candidato";
            this.img_vice.Visible = false;
            // 
            // lab_aviso
            // 
            this.lab_aviso.BackColor = System.Drawing.SystemColors.Control;
            this.lab_aviso.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_aviso.Location = new System.Drawing.Point(40, 396);
            this.lab_aviso.Name = "lab_aviso";
            this.lab_aviso.Size = new System.Drawing.Size(303, 35);
            this.lab_aviso.TabIndex = 35;
            this.lab_aviso.Text = "Aperte CONFIRMA para CONFIRMAR o voto\r\nAperte CORRIGE para REINICIAR o voto\r\n\r\n\r\n" +
    "\r\n";
            this.lab_aviso.Visible = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_voltar.Location = new System.Drawing.Point(-2, -2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 31);
            this.btn_voltar.TabIndex = 36;
            this.btn_voltar.Text = "<-";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // jnl_urna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Urna_2._0.Properties.Resources.fundo_urna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lab_aviso);
            this.Controls.Add(this.lab_digito1);
            this.Controls.Add(this.lab_vice_imagem);
            this.Controls.Add(this.img_vice);
            this.Controls.Add(this.lab_vice_presidente);
            this.Controls.Add(this.lab_partido_presidente);
            this.Controls.Add(this.lab_vice);
            this.Controls.Add(this.lab_nome);
            this.Controls.Add(this.lab_partido);
            this.Controls.Add(this.lab_presidente_imagem);
            this.Controls.Add(this.img_presidente);
            this.Controls.Add(this.lab_nome_presidente);
            this.Controls.Add(this.lab_cargo);
            this.Controls.Add(this.lab_seu_voto);
            this.Controls.Add(this.lab_digito2);
            this.Controls.Add(this.lab_numero);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_corrige);
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.btn_branco);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "jnl_urna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.jnl_urna_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jnl_urna_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.img_presidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_vice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_branco;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.Button btn_corrige;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Label lab_digito1;
        private System.Windows.Forms.Label lab_numero;
        private System.Windows.Forms.Label lab_digito2;
        private System.Windows.Forms.Label lab_cargo;
        private System.Windows.Forms.Label lab_nome_presidente;
        private System.Windows.Forms.PictureBox img_presidente;
        private System.Windows.Forms.Label lab_presidente_imagem;
        private System.Windows.Forms.Label lab_seu_voto;
        private System.Windows.Forms.Label lab_partido;
        private System.Windows.Forms.Label lab_nome;
        private System.Windows.Forms.Label lab_vice;
        private System.Windows.Forms.Label lab_partido_presidente;
        private System.Windows.Forms.Label lab_vice_presidente;
        private System.Windows.Forms.Label lab_vice_imagem;
        private System.Windows.Forms.PictureBox img_vice;
        private System.Windows.Forms.Label lab_aviso;
        private System.Windows.Forms.Button btn_voltar;
    }
}

