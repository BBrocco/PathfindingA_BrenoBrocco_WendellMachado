using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

namespace WindowsFormsApplication2
{
    public class RectManager
    {
        Random randomizer = new Random();
        private List<Rect> rects;
        bool[] can_passList = new bool[] { true, false, true, true, true};
        int ScreenWidth, ScreenHeight,gridX,gridY;
        Rect A, B;
        List<Rect> targetableRects = new List<Rect>();

        
        public RectManager(int width, int height)
        {
            ScreenWidth = width;
            ScreenHeight = height;
        }

        public void CreateGrid(int gridX, int gridY)
        {
            rects = new List<Rect>();
            A = null;
            B = null;

            this.gridX = gridX;
            this.gridY = gridY;

            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    rects.Add(new Rect(ScreenWidth/20 + (ScreenWidth/gridX + 1) * i, ScreenHeight/20 + (ScreenHeight/gridY + 1) * j, ScreenWidth/gridX , ScreenHeight/gridY, can_passList[Convert.ToInt32(randomizer.Next(0,can_passList.Length))], i, j));
                }
            }
        }

        public void GetTargetableRects() {

            if (A != null && B != null)
            {
                for (int h = 0; h < rects.Count; h++) {
                    if (rects[h].can_pass && rects[h] != A){
                        for (int i = -1; i < 2; i++) {
                            for (int j = -1; j < 2; j++){
                                if ((A.position[0] + i) == rects[h].position[0] && (A.position[1] + j) == rects[h].position[1]) {
                                   
                                    if((i + j) == 1 || (i+j) == -1){
                                        rects[h].g = 10;
                                        rects[h].getH(rects[h].position, B.position);                                        

                                    }else {
                                        rects[h].g = 14;
                                        rects[h].getH(rects[h].position, B.position);                                        
                                    }
                                   
                                    targetableRects.Add(rects[h]);
                                }
                            }
                        }
                    }
                }
            }

            ChooseBestRect();
        }

        public void ChooseBestRect() {
           // Rect temp;

            /*int numLength = targetableRects.Count;
           
            //sorting an array
            for (int i = 1; (i <= (numLength - 1)); i++)
            {
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (targetableRects[j + 1].f > targetableRects[j].f)
                    {
                        temp = targetableRects[j];
                        targetableRects[j] = targetableRects[j + 1];
                        targetableRects[j + 1] = temp;
                    }
                }
            }*/


            Rect temp = targetableRects[0];
            
            for (int i = 0; i < targetableRects.Count; i++)
            {
                if(temp.f > targetableRects[i].f){
                    temp = targetableRects[i];
                }

               Console.WriteLine("TAMANHO ARRAY " + targetableRects.Count + " posição " + i + " valor em f " + 
                   targetableRects[i].f + " temp " + temp + " f temp " + temp.f);

            }

            A = temp;
            targetableRects.Clear();
        }

        public void SetPaths(int x, int y)
        {
            for (int i = 0; i < rects.Count; i++)
            {
                if(x > rects[i].x  && y > rects[i].y
		          && x < rects[i].x + rects[i].width && y < rects[i].y + rects[i].height)
                {
                    if(rects[i].can_pass)
                    {
                        Console.WriteLine(rects[i].position[0] + " " + rects[i].position[1]);
                        if (A == null)
                        {
                            A = rects[i];
                            //A.arrayPosition = i;
                            A.ChangeColor(Color.White);
                        }
                        else if(A != null && B == null)
                        {
                            B = rects[i];
                           // B.arrayPosition = i;
                            B.ChangeColor(Color.Red);
                        }
                    }
                }
            }
        }

        public void Draw(Graphics G)
        {
            for (int i = 0; i < rects.Count; i++)
            
            {
                   rects[i].Draw(G);
            }

            if (A != null)
            {
                A.ChangeColor(Color.White);
            }
        }
    }
}
