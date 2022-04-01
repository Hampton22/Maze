using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze2
{
    class MazeLevel1
    {
        Rectangle rectangleOfFinish;
        List<Rectangle> listWalls = new List<Rectangle>();

        public MazeLevel1()
        {
            CreateMaze();
            CreateFinish();
        }

        private void CreateFinish()
        {
            rectangleOfFinish = new Rectangle(0, 200, 50, 50);
            
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
            CreateWall(50, 50, 6, 150);
            CreateWall(50, 250, 6, 200);
            CreateWall(50, 50, 400, 6);
            CreateWall(50, 450, 400, 6);
            CreateWall(450, 50, 6, 400);

            CreateWall(100, 100, 150, 6);
            CreateWall(100, 100, 6, 50);
            CreateWall(50, 200, 100, 6);
            CreateWall(150, 150, 6, 50);
            CreateWall(200, 100, 6, 100);
            CreateWall(200, 200, 150, 6);
            CreateWall(250, 150, 150, 6);
            CreateWall(300, 100, 6, 50);
            CreateWall(350, 50, 6, 50);
            CreateWall(400, 100, 6, 200);
            CreateWall(350, 250, 50, 6);
            CreateWall(350, 250, 6, 100);
            CreateWall(350, 350, 50, 6);
            CreateWall(400, 350, 6, 100);
            CreateWall(300, 400, 50, 6);
            CreateWall(300, 200, 6, 200);
            CreateWall(100, 400, 150, 6);
            CreateWall(200, 300, 6, 100);
            CreateWall(150, 300, 50, 6);
            CreateWall(150, 300, 6, 50);
            CreateWall(100, 200, 6, 100);
            CreateWall(100, 250, 150, 6);
            CreateWall(250, 250, 6, 100);
            CreateWall(250, 350, 50, 6);
            CreateWall(50, 350, 100, 6);

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
