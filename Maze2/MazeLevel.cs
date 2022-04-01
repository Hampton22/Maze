using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze2
{
    class MazeLevel
    {
        Rectangle rectangleOfFinish;
        List<Rectangle> listWalls = new List<Rectangle>();
       
        public MazeLevel()
        {
            CreateMaze();
            CreateFinish();
            //test
        }

        private void CreateFinish()
        {
            rectangleOfFinish = new Rectangle(1150, 100, 50, 50);
        }

        private void CreateWall(int x, int y, int width, int height)
        {
            Rectangle wall = new Rectangle(x, y, width, height);
            listWalls.Add(wall);
        }

        public void DrawMaze(Graphics graphics)
        {
            for (int i = 0; i < listWalls.Count; i++)
            {
                graphics.FillRectangle(Brushes.Black, listWalls[i]);
            }
 
      
            String path = Application.StartupPath + "/Source/finish.jpg";
            Image image = Image.FromFile(path);
            graphics.DrawImage(image, rectangleOfFinish);
        }

        public void CreateMaze()
        {
            listWalls.Clear();
            //начало
            CreateWall(10, 500, 40, 2);
            CreateWall(10, 500, 2, 40);
            CreateWall(10, 540, 40, 2);
            //границы
            //нижние
            CreateWall(50, 540, 2, 60);
            CreateWall(50, 600, 1100, 2);
            CreateWall(1150, 150, 2, 450);
            //верхние
            CreateWall(50, 50, 2, 450);
            CreateWall(50, 50, 1100, 2);
            CreateWall(1150, 50, 2, 50);
            //конец
            CreateWall(1150, 100, 50, 2);
            CreateWall(1150, 150, 50, 2);
            CreateWall(1200, 100, 2, 50);
            //стенки
            CreateWall(150, 100, 2, 500);
            CreateWall(250, 50, 2, 500);
            CreateWall(350, 100, 2, 500);
            CreateWall(450, 50, 2, 500);
            CreateWall(550, 100, 2, 500);
            CreateWall(650, 50, 2, 500);
            CreateWall(850, 50, 2, 500);
            CreateWall(1050, 50, 2, 500);
            CreateWall(750, 100, 2, 500);
            CreateWall(950, 100, 2, 500);
        }

        public bool IsTouchFinish(Ball ball)
        {
            if (rectangleOfFinish.IntersectsWith(ball.boundingBox))
            {
                    return true;
            }
            return false;
        }

        public bool IsTouchBorders(Ball ball)
        {
            foreach (var item in listWalls)
            {
                if (item.IntersectsWith(ball.boundingBox))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
