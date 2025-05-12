using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            listaAgenda.Items.Add("ID: " + txtID.Text + " Evento: " + txtEvento.Text + " Local: " + txtLocal.Text + " Data: " + dataAgenda.Text + " Hora: " + horaAgenda.Text + " Estado do Agendamento: " + estadoAgenda.Text);
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            listaAgenda.Items.Remove(listaAgenda.SelectedItem);
        }

        private void btnapagartudo_Click(object sender, EventArgs e)
        {
            listaAgenda.Items.Clear();
        }
    }
}
