using System;
namespace AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            string typeOfFigure = Console.ReadLine();
            

            if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(area);
            }

            if (typeOfFigure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double area = length * width;
                Console.WriteLine(area);
            }

            if (typeOfFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine(String.Format("{0:0.000}" , area));
            }

            if (typeOfFigure == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                double tbase = double.Parse(Console.ReadLine());
                double area = 0.5 * (height * tbase);
                Console.WriteLine(area);
            }


        }
    }
}
