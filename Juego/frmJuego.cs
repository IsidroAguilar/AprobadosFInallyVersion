using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juego.LALO;

namespace Juego
{
    public partial class frmJuego : Form
    {
        clsJugadores jugador = new clsJugadores();
        private static int contador = 0;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            MostrarPantallaJugador();
        }

        private void MostrarPantallaJugador()
        {
            string Path = "";
            switch (contador)
            {
                case 0:
                    jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador++;
                    break;
                case 1:
                    jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador++;
                    break;
                case 2:
                   jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador++;
                    break;
                case 3:
                    jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador++;
                    break;
                case 4:
                    jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador++;
                    break;
                case 5:
                   jugador.RutasJugadores(contador, ref Path);
                    BackgroundImage = Image.FromFile(Path);
                    contador = 0;
                    break;
                default:
                    MessageBox.Show("Error. Solicite a Sistemas.");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            this.Hide();
            v.Show();
        }
    }
}
