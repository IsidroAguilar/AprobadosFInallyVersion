using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juego.BD;
using Juego.LALO;

namespace Juego
{
    public partial class frmJugadores : Form
    {
        SELECT preguntas = new SELECT();
        clsJugadores jugador = new clsJugadores();
        private string path;
        private int contador = 0;
        frmJuego juego = new frmJuego();

        public frmJugadores()
        {
            InitializeComponent();
        }

        private void Jugadores_Load(object sender, EventArgs e)
        {
            jugador.RegistrarJugadores();
        }

        private void SeleccionarJugador()
        {
          

            switch (lblJugadores.Text)
            {
                case "Jugador 1":
                    jugador.RegistrarJugador(contador, path);
                    lblJugadores.Text = "Jugador 2";
                    contador++;
                    break;
                case "Jugador 2":
                    jugador.RegistrarJugador(contador, path);
                    lblJugadores.Text = "Jugador 3";
                    contador++;
                    break;
                case "Jugador 3":
                    jugador.RegistrarJugador(contador, path);
                    lblJugadores.Text = "Jugador 4";
                    contador++;
                    break;
                case "Jugador 4":
                    jugador.RegistrarJugador(contador, path);
                    lblJugadores.Text = "Jugador 5";
                    contador++;
                    break;
                case "Jugador 5":
                    jugador.RegistrarJugador(contador, path);
                    lblJugadores.Text = "Jugador 6";
                    contador++;
                    break;
                case "Jugador 6":
                    jugador.RegistrarJugador(contador, path);
                    preguntas.GenerarListaPreguntas();
                    this.Hide();
                    juego.Show();
                    break;
                default:
                    MessageBox.Show("Seleccione un jugador válido...");
                    break;
            }
        }

        private void pctBoxRojo_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasRojo.png";
            SeleccionarJugador();
            pctBoxRojo.Visible = false;
        }

        private void pctBoxNaranja_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasNaranja.png";
            SeleccionarJugador();
            pctBoxNaranja.Visible = false;
        }

        private void pctBoxAzul_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasAzul.png";
            SeleccionarJugador();
            pctBoxAzul.Visible = false;
        }

        private void pctBoxGris_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasGris.png";
            SeleccionarJugador();
            pctBoxGris.Visible = false;
        }

        private void pctBoxMorado_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasMorado.png";
            SeleccionarJugador();
            pctBoxMorado.Visible = false;
        }

        private void pctBoxVerde_Click(object sender, EventArgs e)
        {
            path = "Diseño/frmPreguntasVerde.png";
            SeleccionarJugador();
            pctBoxVerde.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJuego v = new frmJuego();
            this.Hide();
            v.Show();
        }
    }
}
