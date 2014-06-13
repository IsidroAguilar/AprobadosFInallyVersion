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
    public partial class PlanearJuego : Form
    {
        public PlanearJuego()
        {
            InitializeComponent();
        }
        BD.SELECT select = new BD.SELECT();
        private void PlanearJuego_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }
        public void LlenarTabla()
        {
            List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
            dtgvActivo.Rows.Clear();
            dtgvInactivo.Rows.Clear();
            foreach (Cuestionario item in tabla)
            {
                if (item.Status == 0)
                {
                    dtgvInactivo.Rows.Add(item.Nombre);
                }
                else
                    dtgvActivo.Rows.Add(item.Nombre);
            }
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
        private void btnActivo_Click(object sender, EventArgs e)
        {
             var cellValue = dtgvInactivo.CurrentCell.Value.ToString();
             int Id = BuscarId(cellValue);
            BD.UPDATE updt=new BD.UPDATE();
            if (updt.Categoria(Id, 1) == true)
                LlenarTabla();
            else
                MessageBox.Show("No se puede cambiar el estado");
        }

        private void btnInactivo_Click(object sender, EventArgs e)
        {
            var cellValue = dtgvActivo.CurrentCell.Value.ToString();
            int Id = BuscarId(cellValue);
            BD.UPDATE updt = new BD.UPDATE();
            if (updt.Categoria(Id, 0) == true)
                LlenarTabla();
            else
                MessageBox.Show("No se puede cambiar el estado");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu v = new Menu();
            v.Show();
            this.Hide();
        }
    }
}
