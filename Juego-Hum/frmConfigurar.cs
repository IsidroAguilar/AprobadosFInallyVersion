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
    public partial class frmConfigurar : Form
    {
        public frmConfigurar()
        {
            InitializeComponent();
        }
        List<Cuestionario> Lista_Cuestionario = new List<Cuestionario>();
        List<Preguntas> Lista_Preguntas = new List<Preguntas>();
        BD.INSERT insert = new BD.INSERT();
        BD.SELECT select = new BD.SELECT();
        BD.DELETE delete = new BD.DELETE();
        int renglon = 0;
        private void frmConfigurar_Load(object sender, EventArgs e)
        {
            Cargar_Listas();
            Llenar_Combo();
        }
        #region Metodos
        public void Cargar_Listas()
        {
            Lista_Cuestionario.Clear();
            Lista_Preguntas.Clear();
            Lista_Cuestionario = select.Cuestionario();
            Lista_Preguntas = select.Preguntas();
        }
        public void Llenar_Combo()
        {
            cmbCuestionario.Items.Clear();
            foreach (Cuestionario item in Lista_Cuestionario)
            {
                cmbCuestionario.Items.Add(item.Nombre);
            }
        }
        public void Llenar_Tabla(int Id)
        {
            dtgvTabla.Rows.Clear();
            foreach (Preguntas item in Lista_Preguntas)
            {
                if (item.Id_cuest==Id)
                {
                    dtgvTabla.Rows.Add(item.Pregunta, item.Respuesta, item.Opcion2, item.Opcion3, item.Opcion4);
                }
            }
        }
        public int Cuestionario_Id(string nombre)
        {
            int Id = 0;
            foreach (Cuestionario item in Lista_Cuestionario)
            {
                if (nombre == item.Nombre)
                {
                    Id = item.Id;
                    break;
                }
            }
            return Id;
        }
        public int Preguntas_Id(string pregunta)
        {
            int Id = 0;
            foreach (Preguntas item in Lista_Preguntas)
            {
                if(pregunta==item.Pregunta)
                {
                    Id = item.Id;
                    break;
                }
            }
            return Id;
        }
        public bool Formulario_Vacio()
        {
            if (cmbCuestionario.Text==""||txtPregunta.Text == ""|| txtRcorrecta.Text == "" || txtROp2.Text == "" || txtROp3.Text == "" || txtROp4.Text == "")
                return true;
            else
                return false;
        }
        public void Limpiar()
        {
            txtPregunta.Clear();
            txtRcorrecta.Clear();
            txtROp2.Clear();
            txtROp3.Clear();
            txtROp4.Clear();
        }
        #endregion

        #region Ventanas
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Cuestionario
        private void btnAddCuestionario_Click(object sender, EventArgs e)
        {
            string nombre = cmbCuestionario.Text;
            if (Cuestionario_Id(nombre) == 0)
            {
                if (insert.Cuestionario(nombre) == true)
                {
                    Cargar_Listas();
                    Llenar_Combo();
                    cmbCuestionario.Text = "";
                }
                else
                    MessageBox.Show("Error de incersión");
            }
            else
                MessageBox.Show("Ya existe dicho cuestionario");
        }
        private void btnDeleteCuestionario_Click(object sender, EventArgs e)
        {
            if (cmbCuestionario.Text !="")
            {
                int Id = Cuestionario_Id(cmbCuestionario.Text);
                if (delete.Cuestionario(Id)==true)
                {
                    Cargar_Listas();
                    Llenar_Combo();
                    cmbCuestionario.Text = "";
                }
                else
                    MessageBox.Show("Error de eliminación");
            }
            else
                MessageBox.Show("No ha seleccionado ningun cuestionario");
        }
        #endregion

        #region Preguntas
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Formulario_Vacio() == true)
                    MessageBox.Show("No ha llenado el fomulario correctamente");
                else
                {
                    string Pregunta = txtPregunta.Text;
                    if (Preguntas_Id(Pregunta) == 0)
                    {
                        int Id_cuest = Cuestionario_Id(cmbCuestionario.Text);
                        if (insert.Preguntas(Id_cuest, Pregunta, txtRcorrecta.Text, txtROp2.Text, txtROp3.Text, txtROp4.Text) == true)
                        {
                            Cargar_Listas();
                            Llenar_Tabla(Id_cuest);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("E R R O R");
                        }
                    }
                    else
                        MessageBox.Show("Ya existe la pregunta");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                renglon = dtgvTabla.CurrentCellAddress.Y;
                var cellValue = dtgvTabla[0, renglon].Value.ToString();
                int Id = Preguntas_Id(cellValue);
                BD.DELETE delete = new BD.DELETE();
                if (delete.Pregunta(Id) == true)
                {
                    int Id_cuest = Cuestionario_Id(cmbCuestionario.Text);
                    Cargar_Listas();
                    Llenar_Tabla(Id_cuest);
                    Limpiar();
                }
                else
                    MessageBox.Show("NO SE ELIMINO");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int renglon = dtgvTabla.CurrentCellAddress.Y;
                string pregunta = dtgvTabla[0, renglon].Value.ToString();
                int Id=Preguntas_Id(pregunta);
                BD.UPDATE update = new BD.UPDATE();
                if (Formulario_Vacio() != true)
                {
                    if (pregunta == txtPregunta.Text)
                    {
                        if (update.Preguntas(txtPregunta.Text, txtRcorrecta.Text, txtROp2.Text, txtROp3.Text, txtROp4.Text, Id) == true)
                        {
                            Cargar_Listas();
                            Llenar_Tabla(Cuestionario_Id(cmbCuestionario.Text));
                            Limpiar();
                        }
                        else
                            MessageBox.Show("Datos llenados incorrectamente");
                    }
                    else
                    {
                        int Id2 = Preguntas_Id(txtPregunta.Text);
                        if (Id2 == 0)
                        {
                            if (update.Preguntas(txtPregunta.Text, txtRcorrecta.Text, txtROp2.Text, txtROp3.Text, txtROp4.Text, Id) == true)
                            {
                                Cargar_Listas();
                                Llenar_Tabla(Cuestionario_Id(cmbCuestionario.Text));
                                Limpiar();
                            }
                            else
                                MessageBox.Show("Datos llenados incorrectamente");
                        }
                        else
                            MessageBox.Show("Ya existe la pregunta");
                    }
                }
                else
                    MessageBox.Show("No se ha llenado el formulario");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        #endregion

        private void cmbCuestionario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Id = Cuestionario_Id(cmbCuestionario.Text);
                Llenar_Tabla(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvTabla.CurrentCellAddress.Y;
            txtPregunta.Text = dtgvTabla[0, r].Value.ToString();
            txtRcorrecta.Text = dtgvTabla[1, r].Value.ToString();
            txtROp2.Text = dtgvTabla[2, r].Value.ToString();
            txtROp3.Text = dtgvTabla[3, r].Value.ToString();
            txtROp4.Text = dtgvTabla[4, r].Value.ToString();
        }


    }
}
