using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CG_lab3
{
    class MyDrawer
    {
        private PictureBox pBox;
        private Bitmap bitmap;
        private int xSize, ySize, step = 1;
        public MyDrawer(Bitmap bmp, PictureBox _pBox)
        {
            bitmap = bmp;
            pBox = _pBox;
            xSize = bitmap.Width;
            ySize = bitmap.Height;
        }
        public Bitmap getBitmap()
        {
            return bitmap;
        }
        public void recurseAlgourithm_x4(Point currentPoint)
        {
            bitmap.SetPixel(currentPoint.X, currentPoint.Y, Color.Red);
            if (currentPoint.X + 1 < xSize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).G != 128)
                recurseAlgourithm_x4(new Point(currentPoint.X + 1, currentPoint.Y));
            if (currentPoint.X - 1 > 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).G != 128)
                recurseAlgourithm_x4(new Point(currentPoint.X - 1, currentPoint.Y));
            if (currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).G != 128)
                recurseAlgourithm_x4(new Point(currentPoint.X, currentPoint.Y + 1));
            if (currentPoint.Y - 1 > 0 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).G != 128)
                recurseAlgourithm_x4(new Point(currentPoint.X, currentPoint.Y - 1));
        }
        public async void recurseAlgourithm_x4_Delay(Point currentPoint)
        {
            bitmap.SetPixel(currentPoint.X, currentPoint.Y, Color.Red);
            pBox.Image = bitmap;
            await Task.Delay(10);
            if (currentPoint.X + 1 < xSize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).G != 128)
                recurseAlgourithm_x4_Delay(new Point(currentPoint.X + 1, currentPoint.Y));
            if (currentPoint.X - 1 > 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).G != 128)
                recurseAlgourithm_x4_Delay(new Point(currentPoint.X - 1, currentPoint.Y));
            if (currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).G != 128)
                recurseAlgourithm_x4_Delay(new Point(currentPoint.X, currentPoint.Y + 1));
            if (currentPoint.Y - 1 > 0 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).G != 128)
                recurseAlgourithm_x4_Delay(new Point(currentPoint.X, currentPoint.Y - 1));
        }
        public void recurseAlgourithm_x8(Point currentPoint)
        {
            if (bitmap.GetPixel(currentPoint.X, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y).G != 128)
            {
                bitmap.SetPixel(currentPoint.X, currentPoint.Y, Color.Red);
                if (currentPoint.X + 1 < xSize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X + 1, currentPoint.Y));
                if (currentPoint.X - 1 >= 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X - 1, currentPoint.Y));
                if (currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X, currentPoint.Y + 1));
                if (currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X, currentPoint.Y - 1));
                if (currentPoint.X + 1 < xSize && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X + 1, currentPoint.Y + 1));
                if (currentPoint.X + 1 < xSize && currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X + 1, currentPoint.Y - 1));
                if (currentPoint.X - 1 >= 0 && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y + 1).R != 255 && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X - 1, currentPoint.Y + 1));
                if (currentPoint.X - 1 >= 0 && currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8(new Point(currentPoint.X - 1, currentPoint.Y - 1));
            }
        }
        public async void recurseAlgourithm_x8_Delay(Point currentPoint)
        {
            if (bitmap.GetPixel(currentPoint.X, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y).G != 128)
            {
                bitmap.SetPixel(currentPoint.X, currentPoint.Y, Color.Red);
                pBox.Image = bitmap;
                await Task.Delay(10);
                if (currentPoint.X + 1 < xSize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X + 1, currentPoint.Y));
                if (currentPoint.X - 1 >= 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X - 1, currentPoint.Y));
                if (currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X, currentPoint.Y + 1));
                if (currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X, currentPoint.Y - 1));
                if (currentPoint.X + 1 < xSize && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y + 1).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X + 1, currentPoint.Y + 1));
                if (currentPoint.X + 1 < xSize && currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X + 1, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X + 1, currentPoint.Y - 1));
                if (currentPoint.X - 1 >= 0 && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y + 1).R != 255 && currentPoint.Y + 1 < ySize && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y + 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X - 1, currentPoint.Y + 1));
                if (currentPoint.X - 1 >= 0 && currentPoint.Y - 1 >= 0 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y - 1).R != 255 && bitmap.GetPixel(currentPoint.X - 1, currentPoint.Y - 1).G != 128)
                    recurseAlgourithm_x8_Delay(new Point(currentPoint.X - 1, currentPoint.Y - 1));
            }
        }
        public async void Algourithm_N3_Delay(Point currentPoint)
        {
            pBox.Image = bitmap;
            await Task.Delay(10);
            int y_tmp = currentPoint.Y;
            bool spanLeft, spanRight;
            while (y_tmp >= 0 && bitmap.GetPixel(currentPoint.X, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X, y_tmp).G != 128)
                y_tmp -= step;
            y_tmp += step;
            spanLeft = spanRight = false;
            while (y_tmp < ySize && bitmap.GetPixel(currentPoint.X, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X, y_tmp).G != 128)
            {
                bitmap.SetPixel(currentPoint.X, y_tmp, Color.Red);
                if (!spanLeft && currentPoint.X > 0 && bitmap.GetPixel(currentPoint.X - step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X - step, y_tmp).G != 128)
                {
                    Algourithm_N3_Delay(new Point(currentPoint.X - step, y_tmp));
                    spanLeft = true;
                }
                else if (spanLeft && currentPoint.X > 0 && bitmap.GetPixel(currentPoint.X - step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X - step, y_tmp).G != 128)
                {
                    spanLeft = false;
                }
                if (!spanRight && currentPoint.X < xSize - step && bitmap.GetPixel(currentPoint.X + step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X + step, y_tmp).G != 128)
                {
                    Algourithm_N3_Delay(new Point(currentPoint.X + step, y_tmp));
                    spanRight = true;
                }
                else if (spanRight && currentPoint.X < xSize - step && bitmap.GetPixel(currentPoint.X + step, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + step, currentPoint.Y).G != 128)
                {
                    spanRight = false;
                }
                y_tmp += step;
            }
        }
        public void Algourithm_N3(Point currentPoint)
        {
            int y_tmp = currentPoint.Y;
            bool spanLeft, spanRight;
            while (y_tmp >= 0 && bitmap.GetPixel(currentPoint.X, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X, y_tmp).G != 128)
                y_tmp -= step;
            y_tmp += step;
            spanLeft = spanRight = false;
            while (y_tmp < ySize && currentPoint.X < xSize && bitmap.GetPixel(currentPoint.X, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X, y_tmp).G != 128)
            { 
                bitmap.SetPixel(currentPoint.X, y_tmp, Color.Red);
                if (!spanLeft && currentPoint.X > 0 && bitmap.GetPixel(currentPoint.X - step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X - step, y_tmp).G != 128)
                {
                    Algourithm_N3(new Point(currentPoint.X - step, y_tmp));
                    spanLeft = true;
                }
                else if (spanLeft && currentPoint.X > 0 && bitmap.GetPixel(currentPoint.X - step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X - step, y_tmp).G != 128)
                {
                    spanLeft = false;
                }
                if (!spanRight && currentPoint.X < xSize - step && bitmap.GetPixel(currentPoint.X + step, y_tmp).R != 255 && bitmap.GetPixel(currentPoint.X + step, y_tmp).G != 128)
                {
                    Algourithm_N3(new Point(currentPoint.X + step, y_tmp));
                    spanRight = true;
                }
                else if (spanRight && currentPoint.X < xSize - step && bitmap.GetPixel(currentPoint.X + step, currentPoint.Y).R != 255 && bitmap.GetPixel(currentPoint.X + step, currentPoint.Y).G != 128)
                {
                    spanRight = false;
                }
                y_tmp += step;
            }
        }
    }
}
