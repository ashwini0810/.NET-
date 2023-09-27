using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndArray
{
   abstract class Shape
    {
        protected int NoOfPoints;
        public void M()
        {

        }

        public abstract void Draw();

        public abstract void Area();
        
    }
    class Square : Shape
    {
        public Square()
        {
            NoOfPoints = 4;
        }
        public override void Area()
        {
            Console.WriteLine("Area of square called");
        }

        public override void Draw()
        {
            Console.WriteLine("Draw of square called");
        }
    }
    class Hexagon : Shape
    {
        public Hexagon()
        {
            NoOfPoints = 4;
        }
        public override void Area()
        {
            Console.WriteLine("Area of hexagon called");
        }

        public override void Draw()
        {
            Console.WriteLine("Draw of hexagon called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square();


            string[] items = { "Item1", "Item2", "Item3", "Item4" };

            Console.WriteLine($"Length {items.Length} and Rank {items.Rank}");

            int[] myints = new int[10];

            for (int i = 0; i < myints.Length; i++)
            {
                myints[i] = (i + 1);
            }

            int x ;
            // M1(1,2,3,4,5);

            //  string y = "10";
            //if( int.TryParse(y,out x))
            //  {
            //      //use x value as it is success
            //  }
            M1(items.GetEnumerator());
            M1(myints.GetEnumerator());

            Square[] squares = new Square[2];
            squares[0] = new Square();
            squares[1] = new Square();
            M1(squares.GetEnumerator());

            Shape[] shapes = new Shape[2];
            shapes[0] = new Square();
            shapes[1] = new Hexagon();
            M1(shapes.GetEnumerator());

            string[,] twod = new string[2, 2];
            twod[0, 0] = "Item1";
            twod[0, 1] = "item11";
            twod[1, 0] = "Item2";
            twod[1, 1] = "Item22";

            string[][] jagged = new string[2][];
            jagged[0] = new string[] { "item1", "item2" };
            jagged[1] = new string[] { "item11", "item22",
                "item33","item44" };
        }
        //static void M1(params string[] arg1)
        //{
        //    //foreach (string item in arg1)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}

        //}
        static void M1(System.Collections.IEnumerator arg1)
        {
            //foreach (string item in arg1)
            //{
            //    Console.WriteLine(item);
            //}

           while( arg1.MoveNext())
            {
                if(arg1.Current is Shape)
                {
                    Shape s = arg1.Current as Shape;
                    s.Draw();
                }else
                Console.WriteLine(arg1.Current);
            }
        }
    }
}
