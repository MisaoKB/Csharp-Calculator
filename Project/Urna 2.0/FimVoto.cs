using System;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using Urna_2._0.Properties;
using Application = System.Windows.Forms.Application;

namespace Urna_2._0
{
    public partial class jnl_fim_voto : Form
    {
        SoundPlayer som = new SoundPlayer(Properties.Resources.fim);
        public jnl_fim_voto()
        {
            InitializeComponent();
            string dia_semana = DateTime.Now.ToString("ddd").ToUpperInvariant();
            string data_hora = DateTime.Now.ToString("G");
            lab_data.Text = String.Concat(dia_semana, " ", data_hora);
        }

        private void tocar_som()
        {
            som.Play();
        }
        private void jnl_urna_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
            }
        }

        private void lab_repetir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is jnl_urna).Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.Cast<Form>().FirstOrDefault(s => s is jnl_inicio).Show();
        }

        private void jnl_fim_voto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void jnl_fim_voto_VisibleChanged(object sender, EventArgs e)
        {
            string dia_semana = DateTime.Now.ToString("ddd").ToUpperInvariant();
            string data_hora = DateTime.Now.ToString("G");
            lab_data.Text = String.Concat(dia_semana, " ", data_hora);
            //tocar_som();

            Form form = sender as Form;
            if (form.Visible == true)
                tocar_som();
        }
    }
}
