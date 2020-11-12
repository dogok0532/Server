using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;

namespace ClientCSharp
{
    public partial class InGameForm : DevExpress.XtraEditors.XtraForm
    {
        Bitmap bitmap;

        int previousX;
        int previousY;

        public InGameForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            previousX = e.X;
            previousY = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            Pen pen = new Pen(Color.Blue, 10);
            pen.StartCap = pen.EndCap = LineCap.Round;

            Graphics graphic = pictureBox.CreateGraphics();
            graphic.DrawLine(pen, previousX, previousY, e.X, e.Y);
            previousX = e.X;
            previousY = e.Y;
            graphic.Dispose();
        }

    }
}