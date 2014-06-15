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
    public partial class frmPreparar : Form
    {
        public frmPreparar()
        {
            InitializeComponent();
        }
        BD.SELECT select = new BD.SELECT();
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Hide();
        }
        public int BuscarId(string Nombre)
        {
            int Id = 0;
            List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
            foreach (Cuestionario item in tabla)
            {
                if (Nombre == item.Nombre)
                {
                    Id = item.Id;
                    break;
                }
            }
            return Id;
        }
        public void LlenarTabla()
        {
            List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
            dtgActivo.Rows.Clear();
            dtgInactivo.Rows.Clear();
            foreach (Cuestionario item in tabla)
            {
                if (item.Status == 0)
                {
                    dtgInactivo.Rows.Add(item.Nombre);
                }
                else
                    dtgActivo.Rows.Add(item.Nombre);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            var cellValue = dtgInactivo.CurrentCell.Value.ToString();
            int Id = BuscarId(cellValue);
            BD.UPDATE updt = new BD.UPDATE();
            if (updt.Cuestionario(Id, 1) == true)
                LlenarTabla();
            else
                MessageBox.Show("No se puede cambiar el estado");
        }

        private void frmPreparar_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            var cellValue = dtgActivo.CurrentCell.Value.ToString();
            int Id = BuscarId(cellValue);
            BD.UPDATE updt = new BD.UPDATE();
            if (updt.Cuestionario(Id, 0) == true)
                LlenarTabla();
            else
                MessageBox.Show("No se puede cambiar el estado");
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnInformación_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta ventana se agregan los cuestionarios, con los cuales los alumnos jugaran en las rondas de juego");
        }
    }
}
