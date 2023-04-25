using System.Drawing;

namespace OOP_lab4._1
{
    public class Circle
    {
        public int r;
        public int x { get; private set; }
        public int y { get; private set; }

        public bool selected { get; private set; } = false; //пометка

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public bool CheckCollision(int dx, int dy) //проверка нажатия на круг
        {
            dx = x - dx; //dx и dy - координаты нажатия на круг
            dy = y - dy;
            if (dx * dx + dy * dy <= r * r) //если мы попали внутрь круга
                return true; //то возращаем true
            else
                return false;
        }
                

        public void Draw(Graphics graph) //метод рисования круга
        {
            Pen pen; //обьект рисования
            if (selected) // если selected = true, то не помечен, тогда
                pen = new Pen(Color.Blue, 5); //помечаем его 
            else
                pen = new Pen(Color.Blue); //если selected = folse
            graph.DrawEllipse(pen, x-r, y-r, 2 * r, 2 * r); //рисуем круг с одинаковым радиусом
        }
        
        public void Select() //функция пометки
        {
            selected = true;
        }

        public void UnSelect() //функция - пометки
        {
            selected = false;
        }
    }
}