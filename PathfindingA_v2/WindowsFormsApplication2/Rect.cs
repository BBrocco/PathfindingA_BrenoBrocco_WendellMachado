using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

namespace WindowsFormsApplication2
{
    class Rect
    {
        private Brush brush;
        public int x, y, height, width,g,h,f;
        public bool can_pass;
        public int[] position;

        public void ChangeColor(Color color)
        {
            this.brush = new SolidBrush(color);
        }
        
        public int getH(int[] positionRect, int[] positionB){
            int i = Math.Abs((positionRect[0] - positionB[0]));
            int j = Math.Abs((positionRect[1] - positionB[1]));
            int h = (i + j) * 10;

            f = g + h;

            return h;
        }


        public Rect(int x, int y, int width, int height, bool CanPass, int PosI, int PosJ) 
        {
            this.can_pass = CanPass;
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.position = new int[] { PosI, PosJ };

            if (this.can_pass)
            {
                this.brush = new SolidBrush(Color.Blue);
            }
            else
            {
                this.brush = new SolidBrush(Color.Black);
            }
        }

        public void Draw(Graphics G)
        {
            G.FillRectangle(this.brush, this.x, this.y, this.width, this.height);
        }
    }
}
