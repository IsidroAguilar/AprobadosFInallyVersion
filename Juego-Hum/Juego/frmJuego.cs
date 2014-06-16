using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace Juego_Hum.Juego
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
            
        }

        private List<int> respuestas = new List<int>();
        private static List<int> ids = new List<int>();
        private List<Cuestionario> cuestionario = new List<Cuestionario>();
        private List<Preguntas> preguntas = new List<Preguntas>();
        private List<Cuestionario> cuestionarioJuego = new List<Cuestionario>();
        private List<PreguntasJuego> preguntasJuego = new List<PreguntasJuego>();
        private BD.SELECT select = new BD.SELECT();
        private int Turno = 0;
        private Stack<Equipo> equiposDatos = new Stack<Equipo>();
        private uint IdPregunta = 0;
        private clsEquipos equipos = new clsEquipos();
        private Chabelo c = new Chabelo();
        private bool comodin = false;
        private string correcta;
        private int maximo;

        #region "EXTRER PREGUNTAS"

        public void Cuestionario()
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

        public void Preguntas()
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
            Cuestionario();
            Preguntas();
            FormularPregunta();
            equiposDatos = equipos.Mostrar();
            Turno = clsTurno.Turno;
            string fondo = "";
            foreach (Equipo item in equiposDatos)
            {
                if (item.equipo == Turno)
                {
                    fondo = item.fondo;

                }
            }

            BackgroundImage = Image.FromFile(fondo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularPregunta()
        {
            int contador = 0;
           maximo = preguntasJuego.Count() + 1;
            
            Random random = new Random();
            int randomQuestion = random.Next(1, maximo);
            
            string[] respuesta = new string[5];
            while (ids.Contains(randomQuestion))
            {
                randomQuestion = random.Next(1, maximo);
            }

            ids.Add(randomQuestion);

            foreach (PreguntasJuego preguntas in preguntasJuego)
            {
                if (preguntas.Id == randomQuestion)
                {
                    txtPregunta.Text = preguntas.Pregunta;
                    IdPregunta = preguntas.Id;

                    int randomAnswer = random.Next(0, 4);
                    int z = 0;
                    while (contador < 4)
                    {
                        while (respuestas.Contains(randomAnswer))
                        {
                            randomAnswer = random.Next(0, 4);
                        }
                        if (z == 0)
                        {
                            respuesta[randomAnswer] = preguntas.Respuesta;
                            correcta = preguntas.Respuesta;
                        }
                        if (z == 1)
                            respuesta[randomAnswer] = preguntas.Opcion2;
                        if (z == 2)
                            respuesta[randomAnswer] = preguntas.Opcion3;
                        if (z == 3)
                            respuesta[randomAnswer] = preguntas.Opcion4;
                        z++;
                        respuestas.Add(randomAnswer);
                        contador++;

                    }
                    btnR1.Text = respuesta[0];
                    btnR2.Text = respuesta[1];
                    btnR3.Text = respuesta[2];
                    btnR4.Text = respuesta[3];

                }
            }





        }

        private bool Respuesta(string respuesta)
        {

            foreach (var item in preguntasJuego)
            {
                if (item.Id == IdPregunta)
                    if (item.Respuesta == respuesta)
                    {

                        return true;
                        break;
                    }
            }
            return false;
        }

        private void Puntaje()
        {
            foreach (Equipo item in equiposDatos)
            {
                if (item.equipo == Turno)
                {
                    item.puntaje += 20;
                }
            }

        }


        private void btnR1_Click(object sender, EventArgs e)
        {
            if (Respuesta(btnR1.Text))
            {
                btnR1.ForeColor = Color.Green;
                btnR1.BackColor = Color.White;
                Puntaje();

            }
            else
            {
                if (btnR2.Text == correcta)
                {
                    btnR2.ForeColor = Color.Green;
                    btnR2.BackColor = Color.White;
                }

                if (btnR3.Text == correcta)
                {
                    btnR3.ForeColor = Color.Green;
                    btnR3.BackColor = Color.White;
                }

                if (btnR4.Text == correcta)
                {
                    btnR4.ForeColor = Color.Green;
                    btnR4.BackColor = Color.White;
                }
            }

            if (clsTurno.Turno == 6)
            {
                clsTurno.Turno = 1;
            }
            else
            {
                clsTurno.Turno += 1;
            }

            btnContinuar.Visible = true;
        }

        private void btnR2_Click(object sender, EventArgs e)
        {
            if (Respuesta(btnR2.Text))
            {
                btnR2.ForeColor = Color.Green;
                btnR2.BackColor = Color.White;
                Puntaje();

            }
            else
            {

                if (btnR1.Text == correcta)
                {
                    btnR1.ForeColor = Color.Green;
                    btnR1.BackColor = Color.White;
                }

                if (btnR3.Text == correcta)
                {
                    btnR3.ForeColor = Color.Green;
                    btnR3.BackColor = Color.White;
                }

                if (btnR4.Text == correcta)
                {
                    btnR4.ForeColor = Color.Green;
                    btnR4.BackColor = Color.White;
                }

            }
            if (clsTurno.Turno == 6)
            {
                clsTurno.Turno = 1;
            }
            else
            {
                clsTurno.Turno += 1;
            }
            btnContinuar.Visible = true;
        }

        private void btnR3_Click(object sender, EventArgs e)
        {
            if (Respuesta(btnR3.Text))
            {
                btnR3.ForeColor = Color.Green;
                btnR3.BackColor = Color.White;
                Puntaje();
                
            }
            else
            {

                if (btnR2.Text == correcta)
                {
                    btnR2.ForeColor = Color.Green;
                    btnR2.BackColor = Color.White;
                }

                if (btnR1.Text == correcta)
                {
                    btnR1.ForeColor = Color.Green;
                    btnR1.BackColor = Color.White;
                }

                if (btnR4.Text == correcta)
                {
                    btnR4.ForeColor = Color.Green;
                    btnR4.BackColor = Color.White;
                }
            }
            if (clsTurno.Turno == 6)
            {
                clsTurno.Turno = 1;
            }
            else
            {
                clsTurno.Turno += 1;
            }
            btnContinuar.Visible = true;
        }

        private void btnR4_Click(object sender, EventArgs e)
        {
            if (Respuesta(btnR4.Text))
            {
                btnR4.ForeColor = Color.Green;
                btnR4.BackColor = Color.White;
                Puntaje();
                
            }
            else
            {

                if (btnR2.Text == correcta)
                {
                    btnR2.ForeColor = Color.Green;
                    btnR2.BackColor = Color.White;
                }

                if (btnR3.Text == correcta)
                {
                    btnR3.ForeColor = Color.Green;
                    btnR3.BackColor = Color.White;
                }

                if (btnR1.Text == correcta)
                {
                    btnR1.ForeColor = Color.Green;
                    btnR1.BackColor = Color.White;
                }
            }
            if (clsTurno.Turno == 6)
            {
                clsTurno.Turno = 1;
            }
            else
            {
                clsTurno.Turno += 1;
            }
            btnContinuar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPuntaje ventana = new frmPuntaje();
            if (clsTurno.Pregunta == maximo - 1)
            {
                MessageBox.Show("Se terminó el juego");
            }
            else

            {
                clsTurno.Pregunta++;
                ventana.Show();
                
                this.Hide();
            }
        }
    }
}
