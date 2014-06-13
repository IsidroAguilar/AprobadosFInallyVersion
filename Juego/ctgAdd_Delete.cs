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
    public partial class ctgAdd_Delete : Form
    {
        string Estado;
        public ctgAdd_Delete(string estado)
        {
            InitializeComponent();
            Estado = estado;
        }

        private void ctgAdd_Delete_Load(object sender, EventArgs e)
        {
            if(Estado=="I")
            {
                btnAdd.Visible = true;
                txtCategoria.Visible = true;
                btnDelete.Visible = false;
                cmbCategoria.Visible = false;
            }
            if(Estado=="D")
            {
                btnAdd.Visible = false;
                txtCategoria.Visible = false;
                btnDelete.Visible = true;
                cmbCategoria.Visible = true;
                LlenarCombo();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BD.INSERT insert = new BD.INSERT();
            string nombre = txtCategoria.Text;
            if (Buscar(nombre) == false)
            {
                if (insert.INSERT_CUESTIONARIO(nombre) == true)
                {
                    AdmnInfo ventana = new AdmnInfo();
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error de incersion");
                }
            }
            else
            {
                MessageBox.Show("ya existe un cuestionario llamado asi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BD.DELETE delete = new BD.DELETE();
            if(delete.Categoria(cmbCategoria.Text)==true)
            {
                AdmnInfo ventana = new AdmnInfo();
                ventana.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        public void LlenarCombo()
        {
            BD.SELECT select = new BD.SELECT();
            List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
            foreach (Cuestionario item in tabla)
            {
                cmbCategoria.Items.Add(item.Nombre);
            }
        }
        public bool Buscar(string Nombre)
        {
            bool exist = false; 
            try
            {
             
                BD.SELECT select = new BD.SELECT();
                List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
                foreach (Cuestionario item in tabla)
                {
                    if (Nombre == item.Nombre)
                    {
                        exist = true;
                        break;
                    }
                }
                return exist;
            }
            catch (Exception)
            {
                return exist;
            }
        }
    }
}
