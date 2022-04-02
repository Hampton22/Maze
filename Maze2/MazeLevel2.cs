using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze2
{
    class MazeLevel2
    {
        Rectangle rectangleOfFinish;
        List<Rectangle> listWalls = new List<Rectangle>();


        public MazeLevel2()
        {
            CreateMaze();
            CreateFinish();
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

        private void CreateFinish()
        {
            rectangleOfFinish = new Rectangle(900, 390, 50, 50);

        }

        private void CreateWall(int x, int y, int width, int height)
        {
            Rectangle wall = new Rectangle(x, y, width, height);
            listWalls.Add(wall);
        }

        public void CreateMaze()
        {
            CreateWall(10, 10, 890, 3);
            CreateWall(10, 440, 890, 3);
            CreateWall(10, 60, 3, 380);
            CreateWall(900, 10, 3, 380);

            CreateWall(100, 10, 3, 50);
            CreateWall(50, 60, 100, 3);
            CreateWall(300, 10, 3, 50);
            CreateWall(465, 10, 3, 50);
            CreateWall(645, 10, 3, 50);
            CreateWall(825, 10, 3, 100);
            CreateWall(825, 110, 40, 3);
            CreateWall(865, 60, 3, 150);
            CreateWall(770, 210, 95, 3);
            CreateWall(770, 160, 60, 3);
            CreateWall(770, 60, 3, 100);
            CreateWall(745, 60, 25, 3);
            CreateWall(745, 60, 3, 200);
            CreateWall(645, 160, 100, 3);
            CreateWall(595, 110, 100, 3);
            CreateWall(695, 60, 3, 50);
            CreateWall(595, 60, 3, 150);
            CreateWall(465, 60, 130, 3);
            CreateWall(555, 110, 3, 50);
            CreateWall(505, 160, 50, 3);
            CreateWall(505, 160, 3, 150);
            CreateWall(505, 310, 50, 3);
            CreateWall(610, 300, 3, 50);
            CreateWall(610, 260, 250, 3);
            CreateWall(505, 260, 40, 3);

            CreateWall(415, 110, 140, 3);
            CreateWall(415, 60, 3, 50);
            CreateWall(365, 60, 50, 3);
            CreateWall(365, 60, 3, 100);
            CreateWall(300, 160, 65, 3);
            CreateWall(300, 160, 3, 200);
            CreateWall(150, 360, 150, 3);
            CreateWall(150, 310, 3, 50);
            CreateWall(100, 310, 50, 3);
            CreateWall(100, 210, 3, 100);
            CreateWall(50, 260, 50, 3);
            CreateWall(10, 210, 50, 3);
            CreateWall(60, 160, 3, 50);
            CreateWall(10, 110, 95, 3);
            CreateWall(105, 110, 3, 50);
            CreateWall(105, 160, 150, 3);
            CreateWall(150, 110, 3, 100);
            CreateWall(200, 60, 3, 100);
            CreateWall(200, 60, 50, 3);
            CreateWall(255, 110, 3, 200);
            CreateWall(300, 310, 125, 3);
            CreateWall(375, 310, 3, 50);
            CreateWall(375, 360, 50, 3);
            CreateWall(425, 360, 3, 50);
            CreateWall(425, 410, 50, 3);
            CreateWall(475, 260, 3, 150);
            CreateWall(375, 260, 100, 3);
            CreateWall(375, 210, 3, 50);
            CreateWall(325, 210, 50, 3);
            CreateWall(325, 210, 3, 50);
            CreateWall(405, 210, 100, 3);
            CreateWall(405, 160, 3, 50);
            CreateWall(405, 160, 50, 3);
            CreateWall(205, 310, 50, 3);
            CreateWall(205, 210, 3, 100);
            CreateWall(155, 260, 50, 3);
            CreateWall(255, 110, 75, 3);
            CreateWall(330, 60, 3, 50);

            CreateWall(545, 210, 150, 3);
            CreateWall(545, 210, 3, 50);

            CreateWall(10, 400, 375, 3);
            CreateWall(340, 340, 3, 60);
            CreateWall(65, 260, 3, 90);
            CreateWall(40, 350, 80, 3);
            CreateWall(505, 350, 270, 3);
            CreateWall(505, 310, 3, 50);
            CreateWall(810, 300, 3, 50);
            CreateWall(810, 300, 50, 3);
            CreateWall(710, 300, 3, 50);
            CreateWall(660, 260, 3, 50);
            CreateWall(760, 260, 3, 40);
            CreateWall(760, 390, 3, 50);
            CreateWall(660, 390, 3, 50);
            CreateWall(560, 390, 3, 50);
            CreateWall(610, 350, 3, 50);
            CreateWall(710, 350, 3, 50);
            CreateWall(810, 350, 3, 50);
            CreateWall(810, 375, 50, 3);
            CreateWall(860, 340, 3, 100);
            CreateWall(760, 300, 50, 3);
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
