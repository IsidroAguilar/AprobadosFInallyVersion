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
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }
        List<Cuestionario> cuestionario = new List<Cuestionario>();
        List<Preguntas> preguntas = new List<Preguntas>();
        List<Cuestionario> cuestionarioJuego = new List<Cuestionario>();
        List<PreguntasJuego> preguntasJuego = new List<PreguntasJuego>();
        BD.SELECT select = new BD.SELECT();
        int Turno = 0;
        Stack<Equipo> equiposDatos = new Stack<Equipo>();

        clsEquipos equipos = new clsEquipos();
        Chabelo c = new Chabelo();
        bool comodin = false;
        #region
        public void TablaCuestionario()
        {
            cuestionario.Clear();
            cuestionarioJuego.Clear();
            cuestionario = select.Cuestionario();
            foreach (Cuestionario cuest in cuestionario)
            {
                if (cuest.Status == 1)
                {
                    cuestionarioJuego.Add(cuest);
                }
            }
        }
        public void TablaPreguntas()
        {
            preguntas.Clear();
            preguntasJuego.Clear();
            preguntas = select.Preguntas();
            uint x = 0;
            foreach (Cuestionario item in cuestionarioJuego)
            {
                foreach (Preguntas item2 in preguntas)
                {
                    if (item2.Id_cuest == item.Id)
                    {
                        x++;
                        PreguntasJuego pregunta = new PreguntasJuego()
                        {
                            Id = x,
                            Pregunta = item2.Pregunta,
                            Respuesta = item2.Respuesta,
                            Opcion2 = item2.Opcion2,
                            Opcion3 = item2.Opcion3,
                            Opcion4 = item2.Opcion4,
                            Status = 0

                        };
                        preguntasJuego.Add(pregunta);
                    }

                }
            }
        }
        #endregion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            equiposDatos = equipos.Mostrar();
            Turno = clsTurno.Turno;
            string fondo = "";
            bool cmd1=false, cmd2=false, cmd3=false;
            foreach (Equipo item in equiposDatos)
            {
                if (item.equipo == Turno)
                {
                    fondo = item.fondo;
                    cmd1 = item.comodin1;
                    cmd2 = item.comodin2;
                    cmd3 = item.comodin3;
                }
            }
            if (cmd1 == false)
                pctcmd1.Visible= false;
            if (cmd2 == false)
                pctcmd2.Visible = false;
            if (cmd3 == false)
                pctcmd3.Visible = false;
            BackgroundImage = Image.FromFile(fondo);
        }

        private void pctcmd1_Click(object sender, EventArgs e)
        {
            if (comodin == false)
            {
                foreach (Equipo item in equiposDatos)
                {
                    if (item.equipo == Turno)
                    {
                        item.comodin1 = false;
                        break;
                    }
                }
                pctcmd1.Visible = false;
                comodin = true;
            }
            else 
                c.Show();
        }

        private void pctcmd2_Click(object sender, EventArgs e)
        {
            if (comodin == false)
            {
                foreach (Equipo item in equiposDatos)
                {
                    if (item.equipo == Turno)
                    {
                        item.comodin2 = false;
                        break;
                    }
                }
                pctcmd2.Visible = false;
                comodin = true;
            }
            else
                c.Show();
        }

        private void pctcmd3_Click(object sender, EventArgs e)
        {
            if (comodin == false)
            {
                foreach (Equipo item in equiposDatos)
                {
                    if (item.equipo == Turno)
                    {
                        item.comodin3 = false;
                        break;
                    }
                }
                pctcmd3.Visible = false;
                comodin = true;
            }
            else
                c.Show();
        }
    }
}
