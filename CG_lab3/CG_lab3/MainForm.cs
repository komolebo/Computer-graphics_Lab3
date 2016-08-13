using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
namespace CG_lab3
{
    public partial class MainForm : Form
    {        
        private int MODE = 0;   // 1 - малюємо область,  2 - ставимо точку всередині фігури, що заливаємо
        private Bitmap bitmap;                              /* Інструменти */
        private Graphics g;                                 /* для         */
        private Pen pen = new Pen(Color.Green, 1);     /* малювання   */
        private MyDrawer myDrawer;   // об'ект із методами для заливки
        private Point previousPoint; // зберігаємо попередню точку для з'єднання їх як сторони многокутника
        public MainForm()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
            bitmap = new Bitmap(pBox.Size.Width, pBox.Size.Height);     /* Початкова     */
            g = Graphics.FromImage(bitmap);                             /* ініціалізація */
            myDrawer = new MyDrawer(bitmap, pBox);                      /* інструментів  */
            btnAlgourithm1.Select();
            ShowDelayBtn.Checked = true;
            testLabel.Text = "Click, move your mouse, click again";
        }
        private void drawPoint(Point pixel, int size, Color color)
        {
            if (pixel.X + size > pBox.Size.Width || pixel.Y + size > pBox.Size.Height || pixel.X - size < 0 || pixel.Y - size < 0)
                return;

            for (int i = -size; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bitmap.SetPixel(pixel.X + j, pixel.Y + i, color);
                    bitmap.SetPixel(pixel.X - j, pixel.Y + i, color);
                }
            }
            bitmap.SetPixel(pixel.X, pixel.Y, pen.Color);
        }
        public void mouseMoving(object sender, MouseEventArgs e)
        {
            if (MODE == 1)  // Малюємо область
            {
                if (previousPoint.IsEmpty)
                    drawPoint(new Point(e.X, e.Y), 2, pen.Color);
                else
                {
                    if (btnAlgourithm2.Checked) pen = new Pen(Color.Green, 3);
                    else pen = new Pen(Color.Green, 1);
                    g.DrawLine(pen, new Point(e.X, e.Y), previousPoint);
                }
                previousPoint = new Point(e.X, e.Y);
                pBox.Image = bitmap;
            }
        }
        public void mouseClick(object sender, MouseEventArgs e)
        {
            if (MODE == 2) // Ставимо точку для заливки
            {
                TimeTakenLbl.Text = "Only for simple show";
                myDrawer = new MyDrawer(bitmap, pBox);
                if (btnAlgourithm1.Checked && ShowDelayBtn.Checked)
                    myDrawer.recurseAlgourithm_x4_Delay(new Point(e.X, e.Y));
                else if (btnAlgourithm1.Checked)
                {
                    Thread th = new Thread(() => { myDrawer.recurseAlgourithm_x4(new Point(e.X, e.Y)); }, 1024 * 1024 * 256);
                    DateTime whenStart = DateTime.Now, whenFinish;
                    th.Start();
                    th.Join();
                    th.Abort();
                    whenFinish = DateTime.Now;
                    pBox.Image = myDrawer.getBitmap();
                    TimeTakenLbl.Text = Convert.ToString(whenFinish - whenStart);
                }
                else if (btnAlgourithm2.Checked && ShowDelayBtn.Checked)
                    myDrawer.recurseAlgourithm_x8_Delay(new Point(e.X, e.Y));
                else if (btnAlgourithm2.Checked)
                {
                    Thread th = new Thread(() => { myDrawer.recurseAlgourithm_x8(new Point(e.X, e.Y)); }, 1024 * 1024 * 1024);
                    DateTime whenStart = DateTime.Now, whenFinish;
                    th.Start();
                    th.Join();
                    th.Abort();
                    whenFinish = DateTime.Now;
                    pBox.Image = myDrawer.getBitmap();
                    TimeTakenLbl.Text = Convert.ToString(whenFinish - whenStart);
                }
                else if (btnAlgourithm3.Checked && ShowDelayBtn.Checked)
                    myDrawer.Algourithm_N3_Delay(new Point(e.X, e.Y));
                else if (btnAlgourithm3.Checked)
                {
                    Thread th = new Thread(() => { myDrawer.Algourithm_N3(new Point(e.X, e.Y)); }, 1024 * 1024 * 1024);
                    DateTime whenStart = DateTime.Now, whenFinish;
                    th.Start();
                    th.Join();
                    th.Abort();
                    whenFinish = DateTime.Now;
                    pBox.Image = myDrawer.getBitmap();
                    TimeTakenLbl.Text = Convert.ToString(whenFinish - whenStart);
                }
                MODE = 0;
                BtnFill.ForeColor = Color.Gainsboro;
                previousPoint = new Point();
                testLabel.Text = "Click, move your mouse, click again";
                return;
            }
            if(MODE == 0)
            {
                MODE = 1;
                BtnFill.ForeColor = Color.Gainsboro;
                testLabel.Text = "Click to finish selecting";
            }
            else
            {
                MODE = 2;
                testLabel.Text = "Click to start filling";
                BtnFill.ForeColor = Color.BlueViolet;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pBox.Size.Width, pBox.Size.Height);     /* Обновлюємо  pictureBox */
            pBox.Image = bitmap;                                        /*                        */
            g = Graphics.FromImage(bitmap);
            TimeTakenLbl.Clear();
            MODE = 0;
            BtnFill.ForeColor = Color.Gainsboro;
            previousPoint.X = previousPoint.Y = 0;
            testLabel.Text = "Click, move your mouse, click again";
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            MODE = 2;
            BtnFill.ForeColor = Color.BlueViolet;
            testLabel.Text = "Click to start filling";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog f = new SaveFileDialog())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    bitmap.Save(f.FileName + ".bmp");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
