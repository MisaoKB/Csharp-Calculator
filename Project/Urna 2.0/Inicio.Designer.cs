namespace Urna_2._0
{
    partial class jnl_inicio
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
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_votar = new System.Windows.Forms.Button();
            this.lab_programa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_info.Font = new System.Drawing.Font("Roboto", 16F);
            this.btn_info.Location = new System.Drawing.Point(272, 364);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(157, 42);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Informações";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_votar
            // 
            this.btn_votar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_votar.Font = new System.Drawing.Font("Roboto", 16F);
            this.btn_votar.Location = new System.Drawing.Point(523, 364);
            this.btn_votar.Name = "btn_votar";
            this.btn_votar.Size = new System.Drawing.Size(157, 42);
            this.btn_votar.TabIndex = 0;
            this.btn_votar.Text = "Votar";
            this.btn_votar.UseVisualStyleBackColor = false;
            this.btn_votar.Click += new System.EventHandler(this.votar);
            // 
            // lab_programa
            // 
            this.lab_programa.AutoSize = true;
            this.lab_programa.Font = new System.Drawing.Font("Roboto Medium", 56F, System.Drawing.FontStyle.Bold);
            this.lab_programa.Location = new System.Drawing.Point(191, 203);
            this.lab_programa.Name = "lab_programa";
            this.lab_programa.Size = new System.Drawing.Size(558, 90);
            this.lab_programa.TabIndex = 4;
            this.lab_programa.Text = "Urna Eletrônica";
            this.lab_programa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jnl_inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.lab_programa);
            this.Controls.Add(this.btn_votar);
            this.Controls.Add(this.btn_info);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "jnl_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.jnl_fim_voto_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jnl_urna_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_votar;
        private System.Windows.Forms.Label lab_programa;
    }
}

