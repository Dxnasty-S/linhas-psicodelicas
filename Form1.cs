using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhas_psicodelicas
{
    public partial class Form1 : Form
    {
        Pen caneta = new Pen(Color.Black);

        Graphics quadro = null;

        static int centroX;
        static int centroY;

        static int inicioX;
        static int inicioY;

        static int fimX;
        static int fimY;

        static int angulo = 0;
        static int tamanho = 0;
        static int incremento = 0;
        static int numLinhas = 0;

        public Form1()
        {
            InitializeComponent();
            inicioX = canvas.Width / 2;
            inicioY = canvas.Height / 2;

        }
        //faz o desenho
        private void DesenhaLinha()
        {
            Random cores = new Random();
            caneta.Color = 
                Color.FromArgb(cores.Next(255),
                cores.Next(255),
                cores.Next(255),
                cores.Next(255));

            angulo = angulo + int.Parse(textBoxAngulo.Text);
            tamanho = tamanho + int.Parse(textBoxIncremento.Text);

            fimX = inicioX + (int) (Math.Cos(angulo * .017453292519) * tamanho);
            fimY = (int) (inicioY + Math.Sin(angulo * .017453292519) * tamanho);

            Point[] pontos =
            {
                new Point(inicioX, inicioY),
                new Point(fimX, fimY)
            };

            inicioX = fimX;
            inicioY = fimY;

            quadro.DrawLines(caneta, pontos);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            caneta.Width = 5;
            quadro = canvas.CreateGraphics();
            for(int i = 0; i < int.Parse(textBoxLinhas.Text); i++)
            {
                DesenhaLinha();
            }
           
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            angulo = int.Parse(textBoxAngulo.Text);
            tamanho = int.Parse(textBoxTamanho.Text);
            incremento = int.Parse(textBoxIncremento.Text);

            inicioX = canvas.Width / 2;
            inicioY = canvas.Height / 2;

            canvas.Refresh();
        }
    }
}
