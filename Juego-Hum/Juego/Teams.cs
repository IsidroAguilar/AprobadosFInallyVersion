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
    public partial class Teams : Form
    {
        clsEquipos equipos = new clsEquipos();
        frmPuntaje ventana = new frmPuntaje();
        static int x = 0;
        string fondo = "";
        public Teams()
        {
            InitializeComponent();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
        }
        private void SeleccionarJugador(string fondo)
        {
            Equipo equipo;
            switch (lblJugadores.Text)
            {
                case "Jugador 1":
                    x++;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1=true,
                        comodin2=true,
                        comodin3=true
                    };
                    equipos.Insertar(equipo);
                    lblJugadores.Text = "Jugador 2";
                    break;
                case "Jugador 2":
                    x++;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1 = true,
                        comodin2 = true,
                        comodin3 = true
                    };
                    equipos.Insertar(equipo);
                    lblJugadores.Text = "Jugador 3";
                    break;
                case "Jugador 3":
                    x++;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1 = true,
                        comodin2 = true,
                        comodin3 = true
                    };
                    equipos.Insertar(equipo);
                    lblJugadores.Text = "Jugador 4";
                    break;
                case "Jugador 4":
                    x++;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1 = true,
                        comodin2 = true,
                        comodin3 = true
                    };
                    equipos.Insertar(equipo);
                    lblJugadores.Text = "Jugador 5";
                    break;
                case "Jugador 5":
                    x++;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1 = true,
                        comodin2 = true,
                        comodin3 = true
                    };
                   equipos.Insertar(equipo);
                    lblJugadores.Text = "Jugador 6";
                    break;
                case "Jugador 6":
                    x++;
                    clsTurno.Turno = 1;
                    equipo = new Equipo()
                    {
                        equipo = x,
                        fondo = fondo,
                        puntaje = 0,
                        comodin1 = true,
                        comodin2 = true,
                        comodin3 = true
                    };
                    equipos.Insertar(equipo);
                    ventana.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Seleccione un jugador válido...");
                    break;
            }
        }
        private void pctBoxVerde_Click(object sender, EventArgs e)
        {
            fondo= "Diseño/frmPreguntasVerde.png";
            SeleccionarJugador(fondo);
            pctBoxVerde.Visible = false;
        }

        private void pctBoxRojo_Click(object sender, EventArgs e)
        {
            fondo = "Diseño/frmPreguntasRojo.png";
            SeleccionarJugador(fondo);
            pctBoxRojo.Visible = false;
        }

        private void pctBoxNaranja_Click(object sender, EventArgs e)
        {
            fondo = "Diseño/frmPreguntasNaranja.png";
            SeleccionarJugador(fondo);
            pctBoxNaranja.Visible = false;
        }

        private void pctBoxAzul_Click(object sender, EventArgs e)
        {
            fondo = "Diseño/frmPreguntasAzul.png";
            SeleccionarJugador(fondo);
            pctBoxAzul.Visible = false;
        }

        private void pctBoxGris_Click(object sender, EventArgs e)
        {
            fondo = "Diseño/frmPreguntasGris.png";
            SeleccionarJugador(fondo);
            pctBoxGris.Visible = false;
        }

        private void pctBoxMorado_Click(object sender, EventArgs e)
        {
            fondo = "Diseño/frmPreguntasMorado.png";
            SeleccionarJugador(fondo);
            pctBoxMorado.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
