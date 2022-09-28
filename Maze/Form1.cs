using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {

        //Este sonido cuando toco paredes.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Si ganas se muestra mensage y cierra.
            finishSoundPlayer.Play();
            MessageBox.Show("Felicidades!");
            Close();
        }
        /// <summary>
        /// El metodo mueve el puntero a 10 px debajo a la derecha 
        /// del comienzo del laberinto ademas suena sonido.
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            //Si mouse toca pared
            //se llama a MoveToStart() resetea posicion
            MoveToStart();
        }
    }
}
