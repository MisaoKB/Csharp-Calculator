namespace Ligue_4
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
            this.lab_titulo = new System.Windows.Forms.Label();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_titulo
            // 
            this.lab_titulo.AutoSize = true;
            this.lab_titulo.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_titulo.ForeColor = System.Drawing.Color.Firebrick;
            this.lab_titulo.Location = new System.Drawing.Point(313, 75);
            this.lab_titulo.Name = "lab_titulo";
            this.lab_titulo.Size = new System.Drawing.Size(175, 59);
            this.lab_titulo.TabIndex = 0;
            this.lab_titulo.Text = "Ligue 4";
            // 
            // btn_jogar
            // 
            this.btn_jogar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_jogar.Location = new System.Drawing.Point(310, 349);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(181, 64);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // img_logo
            // 
            this.img_logo.Image = global::Ligue_4.Properties.Resources.logo;
            this.img_logo.Location = new System.Drawing.Point(334, 168);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(132, 140);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 2;
            this.img_logo.TabStop = false;
            // 
            // jnl_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.lab_titulo);
            this.Name = "jnl_inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ligue 4";
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_titulo;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.PictureBox img_logo;
    }
}

