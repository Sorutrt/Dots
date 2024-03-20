using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            try
            {
                int positionX = int.Parse(txtboxPositionX.Text);
                int positionY = int.Parse(txtboxPositionY.Text);

                MessageBox.Show($"X: {positionX}, Y: {positionY}");


                Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                g.DrawEllipse(Pens.Black, positionX, positionY, 10, 10);

                //リソースを解放する
                g.Dispose();

                //PictureBox1に表示する
                pictureBox1.Image = canvas;
            }
            catch
            {
                MessageBox.Show("X,Yに数値以外を入力しているか、数値が大きすぎます");
            }
        }
    }
    
}
