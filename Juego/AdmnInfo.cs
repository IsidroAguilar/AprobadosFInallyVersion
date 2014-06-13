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
    public partial class AdmnInfo : Form
    {
        public AdmnInfo()
        {
            InitializeComponent();
        }
         BD.SELECT select = new BD.SELECT();
        private void AdmnInfo_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }
        
        private void ctgAdd_Click(object sender, EventArgs e)
        {
            ctgAdd_Delete ventana = new ctgAdd_Delete("I");
            ventana.Show();
            this.Hide();
        }

        private void ctgRemove_Click(object sender, EventArgs e)
        {
            ctgAdd_Delete ventana = new ctgAdd_Delete("D");
            ventana.Show();
        }

        private void cmbCtgr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Id = BuscarId(cmbCtgr.Text);
                LlenarTabla(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int r = dtgvTabla.CurrentCellAddress.Y;

           var cellValue= dtgvTabla[0, r].Value.ToString();
            BD.DELETE delete=new BD.DELETE();
            if (delete.Pregunta(cellValue) == true)
            {
                int Id = BuscarId(cmbCtgr.Text);
                LlenarTabla(Id);
                MessageBox.Show("ELIMINADO");
            }
            else
                MessageBox.Show("NO SE ELIMINO");
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Id_ctg=BuscarId(cmbCtgr.Text);
                string Pregunta = txtPregunta.Text;
                if (ExistePregunta(Pregunta)!=true)
                {
                    string Rcorrecta = txtRcorrecta.Text;
                    string ROpcion2 = txtROp2.Text;
                    string ROpcion3 = txtROp3.Text;
                    string ROpcion4 = txtROp4.Text;
                    BD.INSERT insert = new BD.INSERT();
                    if (insert.INSERT_PREGUNTAS(Id_ctg, Pregunta, Rcorrecta, ROpcion2, ROpcion3, ROpcion4) == true)
                    {
                        MessageBox.Show("INSERTADO");
                        LlenarTabla(Id_ctg);
                    }
                    else
                        MessageBox.Show("ERROR DE INCERSION");
                }
                else
                {
                    MessageBox.Show("Ya existe esa pregunta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void dtgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //int  c = dtgvTabla.CurrentCellAddress.X;
           int r = dtgvTabla.CurrentCellAddress.Y;
           txtPregunta.Text = dtgvTabla[0, r].Value.ToString();
           txtRcorrecta.Text = dtgvTabla[1, r].Value.ToString();
           txtROp2.Text = dtgvTabla[2, r].Value.ToString();
           txtROp3.Text = dtgvTabla[3, r].Value.ToString();
           txtROp4.Text = dtgvTabla[4, r].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int r = dtgvTabla.CurrentCellAddress.Y;

           string pregunta = dtgvTabla[0, r].Value.ToString();
            int Id = PreguntaId(pregunta);
            BD.UPDATE update = new BD.UPDATE();
            bool existe=ExistePregunta(txtPregunta.Text);
            if (existe == false && pregunta != txtPregunta.Text)
            {
                if (update.Preguntas(txtPregunta.Text, txtRcorrecta.Text, txtROp2.Text, txtROp3.Text, txtROp4.Text, Id) == true)
                {
                    MessageBox.Show("Pregunta Actualizada");
                    int Idctg = BuscarId(cmbCtgr.Text);
                    LlenarTabla(Idctg);
                }
                else
                {
                    MessageBox.Show("No se guardaron los cambios");
                }
            }
            else
            {
                if (existe == true && pregunta == txtPregunta.Text)
                {
                    if (update.Preguntas(txtPregunta.Text, txtRcorrecta.Text, txtROp2.Text, txtROp3.Text, txtROp4.Text, Id) == true)
                    {
                        MessageBox.Show("Pregunta Actualizada");
                        int Idctg = BuscarId(cmbCtgr.Text);
                        LlenarTabla(Idctg);
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron los cambios");
                    }
                }
                else
                    MessageBox.Show("Ya existe es pregunta");
            }
        }
        #region METODOS
        public bool ExistePregunta(string Pregunta)
        {
            bool valor = false;
            try
            {
                List<Preguntas> tabla = new List<Preguntas>(select.Preguntas());
                dtgvTabla.Rows.Clear();
                foreach (Preguntas item in tabla)
                {
                    if (Pregunta == item.Pregunta)
                    {
                        valor = true;
                        break;
                    }
                }
                return valor;
            }
            catch (Exception)
            {
                return valor;
            }

        }
        public int PreguntaId(string Pregunta)
        {
            int valor = 0;
            try
            {
                List<Preguntas> tabla = new List<Preguntas>(select.Preguntas());
                dtgvTabla.Rows.Clear();
                foreach (Preguntas item in tabla)
                {
                    if (Pregunta == item.Pregunta)
                    {
                        valor = item.Id;
                        break;
                    }
                }
                return valor;
            }
            catch (Exception)
            {
                return valor;
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
        public void LlenarCombo()
        {

            List<Cuestionario> tabla = new List<Cuestionario>(select.Cuestionario());
            foreach (Cuestionario item in tabla)
            {
                cmbCtgr.Items.Add(item.Nombre);
            }
        }
        public void LlenarTabla(int Id)
        {
            List<Preguntas> tabla = new List<Preguntas>(select.Preguntas());
            dtgvTabla.Rows.Clear();
            foreach (Preguntas item in tabla)
            {
                if (item.Id_cuest == Id)
                {
                    dtgvTabla.Rows.Add(item.Pregunta, item.Respuesta, item.Opcion2, item.Opcion3, item.Opcion4);
                }
            }
            tabla.Last();

        }
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu v = new Menu();
            v.Show();
            this.Hide();
        }

    }
}
