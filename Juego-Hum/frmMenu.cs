using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Hum
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfigurar ventana = new frmConfigurar();
            ventana.Show();
            this.Hide();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            frmPreparar ventana = new frmPreparar();
            ventana.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmInformación ventana = new frmInformación();
            ventana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Juego.Teams ventana = new Juego.Teams();
            ventana.Show();
            this.Hide();
        }
    }
}
