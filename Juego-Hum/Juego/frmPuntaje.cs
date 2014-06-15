using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Hum.Juego
{
    public partial class frmPuntaje : Form
    {
        public frmPuntaje()
        {
            InitializeComponent();
        }
        Stack<Equipo> equiposDatos = new Stack<Equipo>();
        clsEquipos equipos = new clsEquipos();
        int Turno = 0;
        private void btnPreguntar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPuntaje_Load(object sender, EventArgs e)
        {
            Turno = clsTurno.Turno;
            extraer();
            string fondo = Buscar(Turno);
            BackgroundImage = Image.FromFile(fondo);
            BackgroundImageLayout = ImageLayout.Stretch;
           int progValue=Progress(Turno);
           progressBar.Value = progValue;
        }
        public int Progress(int Eq)
        {
            int progreso=0;
            foreach (Equipo item in equiposDatos)
            {
                if (item.equipo == Eq)
                {
                    progreso = item.puntaje;
                }
            }
            return progreso;
        }
        public string Buscar(int Eq)
        {
            string fondo = "";
            foreach (Equipo item in equiposDatos)
            {
                if (item.equipo == Eq)
                {
                    fondo = item.fondo;
                }
            }
            return fondo;
        }
        public void extraer()
        {
            equiposDatos = equipos.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJuego ventana = new frmJuego();
            ventana.Show();
            this.Hide();
        }
    }
}
