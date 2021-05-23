using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace individual_task
{
    class CEmblem
    {
        public int x;
        public int y;
        public int size;
        public int count;
        public string s;
        public bool RE;


        static Color color = Color.Black;
        Pen pen = new Pen(color, 3);
        Pen penB = new Pen(Color.Black, 3);
        Pen penW = new Pen(Color.White, 3);


        public CEmblem(int x, int y ,string s, int size)
        {
            this.x = x;
            this.y = y;
            this.s = s;
            this.size = size;
            RE = false;
        }

        //actions with figures
        public void Draw(PictureBox b, Pen pen)
        {
            Graphics g = b.CreateGraphics();
            RE = false;
            int xOfromb = (this.size / 2 + this.x);
            int yOfromb = (this.size / 2 + this.y);
            g.DrawEllipse(pen, new Rectangle(x, y, this.size, this.size));
            g.DrawRectangle(pen, new Rectangle(x, y, size, size));
            g.DrawRectangle(pen, new Rectangle(xOfromb - this.size / 3, yOfromb - this.size / 3, Convert.ToInt32(size / Math.Sqrt(2)), Convert.ToInt32(size / Math.Sqrt(2))));
        }
        public void Rotate(PictureBox b, Pen pen)
        {
            Graphics graphic = b.CreateGraphics();
           
            RE = true;

            graphic.DrawEllipse(pen, new Rectangle(x, y, this.size, this.size));

            int xOfromb = (this.size / 2 + this.x);
            int yOfromb = (this.size / 2 + this.y);

            graphic.DrawPolygon(pen, new Point[4] { new Point(xOfromb - this.size / 2, yOfromb), new Point(xOfromb, yOfromb - this.size / 2), new Point(xOfromb + this.size / 2, yOfromb), new Point(xOfromb, yOfromb + this.size / 2) });         
            graphic.DrawPolygon(pen, new PointF[4] { new PointF(xOfromb - (float)Math.Sqrt(2.0) * (this.size / 2), yOfromb), 
                                                     new PointF(xOfromb, yOfromb - (this.size / 2) * (float)Math.Sqrt(2.0)), 
                                                     new PointF(xOfromb + (this.size / 2) * (float)Math.Sqrt(2.0), yOfromb),
                                                     new PointF(xOfromb, yOfromb + (this.size / 2) * (float)Math.Sqrt(2.0)) });
        }



        //scale up & down
        public void ScalePlus()
        {
            this.size++;
        }
        public void ScaleMinus()
        {
            this.size--;
        }

        //defaul move figure
        public void MoveRight()
        {
            if (x <= 478 - size)
            {
                x++;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveLeft()
        {
            if (x >= 1)
            {
                x--;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveUp()
        {
            if (x <= 435 - this.size)
            {
                y++;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }
        public void MoveDown()
        {
            if (y >= 1)
            {
                y--;
            }
            else
            {
                MessageBox.Show("Вы достигли границы холста");
            }
        }

        //move max figure
        public void MoveUpMax()
        {
            y = 0;
        }
        public void MoveDownMax()
        {
            y = 435 - size;
        }
        public void MoveLeftMax()
        {
            x = 0;
        }
        public void MoveRightMax()
        {
            x = 478 - size;
        }
  
        public override string ToString()
        {
            return s ;
        }


        //operation show/hide 
        public void Hide()
        {
            color = Color.White;
        }
        public void Show()
        {
            color = Color.Yellow;
        }
    }
}
