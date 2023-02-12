

namespace LinecComparisonProblem
{
    public class CompareLines

    { 
        public static void Calculate()

        {

        
        double x1, y1, x2, y2;
        double length;

        Console.WriteLine("Enter coordinates of start point x1 & y1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates of end point x2 & y2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            length = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2));
            Console.WriteLine("Lenght of a Line is : " + length + " cm");

        }
     }
}


