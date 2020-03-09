using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public abstract class Widget
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ")");
        }
    }

    class Square : Widget
    {
        public Square()
        {
            this.Name = "Square";
        }

        public Square(int s)
        {
            this.Name = "Square";

            // Square height and width are equal
            Height = Width = s;
        }
        public void Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }


            set
            {
                this._height = this._width = value;
            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }


            set
            {
                this._width = this._height = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ") height=" + Height + " Width=" + Width);
        }
    }

    class Rectangle : Widget
    {
        public Rectangle()
        {
            this.Name = "Rectangle";
        }
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;

            this.Name = "Rectangle";
        }

        public void Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Height { get; set; }
        public int Width { get; set; }
        public override void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ") height=" + Height + " Width=" + Width);
        }
    }

    class Circle : Widget
    {
        public Circle()
        {
            this.Name = "Circle";
        }

        public void Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Width { get; set; }

        public override void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ") Diameter=" + Width);
        }
    }

    class Ellipse : Widget
    {
        public Ellipse()
        {
            this.Name = "Ellipse";
        }

        public void Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public override void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ") Vertical Diam=" + Height + " Horizontal Diam=" + Width);
        }
    }

    class TextBox : Rectangle
    {
        public TextBox()
        {
            this.Name = "TextBox";
            this.Colour = "Red";    // default colour
        }

        public TextBox(string s)
        {
            this.Text = s;
            this.Name = "TextBox";
        }

        public string Colour { get; set; }

        public string Text { get; set; }

        public override void Draw()
        {
            Console.WriteLine(this.Name + " (x:" + X + ",y:" + Y + ") height=" + Height + " Width=" + Width + " Colour=" + Colour + " Text=" + Text);
        }

    }
    public class Canvas
    {
        static void Main()
        {
            Square sq = new Square(50);
            sq.X = 10;
            sq.Y = 20;
            sq.Draw();

            Rectangle rec = new Rectangle(20, 30);
            rec.Coordinates(15, 18);
            rec.Draw();

            Circle c = new Circle();
            c.Coordinates(25, 35);
            c.Width = 20;
            c.Draw();

            Ellipse e = new Ellipse();
            e.Coordinates(35, 45);
            e.Height = 30;
            e.Width = 20;
            e.Draw();

            // Textbox - with text content
            TextBox t1 = new TextBox("test content");
            t1.Coordinates(20, 30);
            t1.Height = 30;
            t1.Width = 40;
            t1.Colour = "Green";
            t1.Draw();

            // Textbox - no text content
            TextBox t2 = new TextBox();
            t2.Coordinates(10, 20);
            t2.Height = 20;
            t2.Width = 30;
            t2.Draw();

            Console.ReadLine();
        }
    }
}
