using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdmnInfo ventana = new AdmnInfo();
            ventana.Show();
            this.Hide();
        }

       

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnPlanear_Click(object sender, EventArgs e)
        {
            PlanearJuego v = new PlanearJuego();
            v.Show();
            Hide();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmJugadores v = new frmJugadores();
            v.Show();
            Hide();
        }
    }
}
