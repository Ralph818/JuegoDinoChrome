using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDinoChrome
{
    public partial class Form1 : Form
    {
        int CambioApariencia;
        int PosicionInicialPisoX;
        int PosicionInicialPisoY;
        int Velocidad = 5;

        bool BrincoDelDino;
        bool InicioJuego = true;

        Random RnTipoObstaculo;
        List<PictureBox> ListaObstaculos;

        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            CambioApariencia = 0;
            BrincoDelDino = false;
            lblPuntuacion.Text = "0";
            RnTipoObstaculo = new Random();
            ListaObstaculos = new List<PictureBox>();

            CrearObstaculo(ListaObstaculos, this);

            PosicionInicialPisoX = 12;
            PosicionInicialPisoY = 197;
            lblGo.Visible = false;
            GameOver.Visible = false;
            
        }

        public void CrearObstaculo(List<PictureBox> ListaObstaculos, Form panelJuegoUno)
        {
            int TipoObstaculo = RnTipoObstaculo.Next(1, 4);
            PictureBox pb = new PictureBox();
            int posicionObstaculo = (TipoObstaculo == 1) ? 200 : 200; ;
            pb.Location = new Point(388, posicionObstaculo);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("obs" + TipoObstaculo);
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaObstaculos.Add(pb);
            panelJuegoUno.Controls.Add(pb);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!BrincoDelDino)
            {
                // Animación del Dino (Movimiento Caminar)
                Dino.Image = (CambioApariencia == 0) ? Properties.Resources.Dino3 : Properties.Resources.Dino;
                CambioApariencia = (CambioApariencia == 0) ? 1 : 0;
            }

            DetectorChoques.Location = Dino.Location;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // El dino brinco
            if (BrincoDelDino)
            {
                Dino.Image = Properties.Resources.Dino2;
                int Brinco = Dino.Location.Y - 10;
                Dino.Location = new Point(Dino.Location.X, Brinco);
                if (Brinco <= 10)
                {
                    BrincoDelDino = false;
                }
            }
            else
            {
                if (Dino.Location.Y < PosicionInicialPisoY)
                {
                    int Brinco = Dino.Location.Y + 10;
                    Dino.Location = new Point(Dino.Location.X, Brinco);
                }
            }

            // Animación de carretera
            DetectorChoques.Location = Dino.Location;
            int Movimiento = Piso.Location.X - 10;
            Piso.Location = new Point(Movimiento, Piso.Location.Y);

            // Repetir la animación de la carretera
            if (Piso.Location.X < -200)
            {
                Piso.Location = new Point(PosicionInicialPisoX, Piso.Location.Y);

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Leer los obstáculos generados
            for (int i=0; i<ListaObstaculos.Count; i++)
            {
                int MovimientoX;
                MovimientoX = ListaObstaculos[i].Location.X;
                MovimientoX = MovimientoX - Velocidad;
                ListaObstaculos[i].Location = new Point(MovimientoX, ListaObstaculos[i].Location.Y);
            }

            // Hay elementos en la lista de obstáculos
            if (ListaObstaculos.Count > 0)
            {
                if (ListaObstaculos[(ListaObstaculos.Count - 1)].Location.X < -200)
                {
                    CrearObstaculo(ListaObstaculos, this);
                }
            }    

            if (ListaObstaculos.Count > 0)
            {
                for (int i = 0; i < ListaObstaculos.Count; i++)
                {
                    if (ListaObstaculos[i].Location.X < -200) // Si el obstáculo ya pasó
                    {
                        if (ListaObstaculos[i].Location.X < Dino.Location.X)
                        {
                            lblPuntuacion.Text = Convert.ToString(Convert.ToInt32(lblPuntuacion.Text) + 1);
                        }
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);
                        //Velocidad++;

                    }
                    // Si hay choques con los obstáculos
                    if (ListaObstaculos[i].Bounds.IntersectsWith(DetectorChoques.Bounds))
                    {
                        timer1.Stop(); 
                        timer2.Stop(); 
                        timer3.Stop();
                        GameOver.Visible = true;
                        lblGo.Visible = true;
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);
                        
                    }

                }
            }    


        }

        private void GameOver_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Space)) && (BrincoDelDino == false))
            {
                // Iniciar el juego cuando se presiona la barra
                if (InicioJuego)
                {
                    IniciarJuego();
                    InicioJuego = false;
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                }
                if (Dino.Location.Y >= PosicionInicialPisoY)
                {
                    Dino.Image = Properties.Resources.Dino2;
                    BrincoDelDino = true;
                }
            }
        }
    } 
}
