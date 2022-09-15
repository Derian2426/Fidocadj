using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fidocadj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmCircuito.Text = "Circuito";
            cmCircuito.Items.Add("Parte Inferior");
            cmCircuito.Items.Add("Parte Superior");
            cmCircuito.Items.Add("Serigrafia");
            for (int i = 1; i < 13; i++)
            {
                cmCircuito.Items.Add("Otros "+i);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new Point(12, 3);
            imgPictureBox.Size = new Size(140, 140);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.Image = Image.FromFile(@"D:\Imagenes\D96.jpg");
            Controls.Add(imgPictureBox);
            imgPictureBox.Visible = true;
        }

        private void archivoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moverMouse(object sender, MouseEventArgs e)
        {
            var x=MousePosition.X;
            var y = MousePosition.Y;
            txt_descripcion.Text = x + "; " + y +" ("+x*100 +"mm ;"+y*100+ "mm )";
        }

        private void Busqueda(object sender, EventArgs e)
        {

        }
    }
}
