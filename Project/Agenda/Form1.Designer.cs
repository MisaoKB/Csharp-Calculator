namespace Agenda
{
    partial class Form1
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
            this.calendarioAgenda = new System.Windows.Forms.MonthCalendar();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.horaAgenda = new System.Windows.Forms.TextBox();
            this.estadoAgenda = new System.Windows.Forms.ComboBox();
            this.dataAgenda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listaAgenda = new System.Windows.Forms.ListBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btnapagartudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendarioAgenda
            // 
            this.calendarioAgenda.Location = new System.Drawing.Point(54, 50);
            this.calendarioAgenda.Name = "calendarioAgenda";
            this.calendarioAgenda.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(293, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(293, 115);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(414, 20);
            this.txtEvento.TabIndex = 2;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(293, 153);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(414, 20);
            this.txtLocal.TabIndex = 3;
            // 
            // horaAgenda
            // 
            this.horaAgenda.Location = new System.Drawing.Point(399, 193);
            this.horaAgenda.Name = "horaAgenda";
            this.horaAgenda.Size = new System.Drawing.Size(122, 20);
            this.horaAgenda.TabIndex = 4;
            // 
            // estadoAgenda
            // 
            this.estadoAgenda.FormattingEnabled = true;
            this.estadoAgenda.Items.AddRange(new object[] {
            "Concluído",
            "Pendente",
            "Cancelado",
            "Em Espera",
            "Em Andamento"});
            this.estadoAgenda.Location = new System.Drawing.Point(527, 193);
            this.estadoAgenda.Name = "estadoAgenda";
            this.estadoAgenda.Size = new System.Drawing.Size(180, 21);
            this.estadoAgenda.TabIndex = 5;
            // 
            // dataAgenda
            // 
            this.dataAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAgenda.Location = new System.Drawing.Point(293, 193);
            this.dataAgenda.Name = "dataAgenda";
            this.dataAgenda.Size = new System.Drawing.Size(100, 20);
            this.dataAgenda.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado do Agendamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Agenda Virtual";
            // 
            // listaAgenda
            // 
            this.listaAgenda.FormattingEnabled = true;
            this.listaAgenda.Location = new System.Drawing.Point(54, 224);
            this.listaAgenda.Name = "listaAgenda";
            this.listaAgenda.Size = new System.Drawing.Size(653, 173);
            this.listaAgenda.TabIndex = 14;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(425, 60);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(90, 36);
            this.btnadicionar.TabIndex = 15;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(521, 60);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(90, 36);
            this.btnapagar.TabIndex = 16;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btnapagartudo
            // 
            this.btnapagartudo.Location = new System.Drawing.Point(617, 60);
            this.btnapagartudo.Name = "btnapagartudo";
            this.btnapagartudo.Size = new System.Drawing.Size(90, 36);
            this.btnapagartudo.TabIndex = 17;
            this.btnapagartudo.Text = "Apagar Tudo";
            this.btnapagartudo.UseVisualStyleBackColor = true;
            this.btnapagartudo.Click += new System.EventHandler(this.btnapagartudo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapagartudo);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.listaAgenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAgenda);
            this.Controls.Add(this.estadoAgenda);
            this.Controls.Add(this.horaAgenda);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.calendarioAgenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioAgenda;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox horaAgenda;
        private System.Windows.Forms.ComboBox estadoAgenda;
        private System.Windows.Forms.DateTimePicker dataAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listaAgenda;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btnapagartudo;
    }
}

