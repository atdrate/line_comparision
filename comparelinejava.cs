

namespace line_comparision
{
    internal class comparelinejava

    {
        public static void linebycomparetomethod()
        {

            double x1, x2, y1, y2;

            Console.WriteLine("Enter co-ordinates of First Line ");
            Console.WriteLine("Enter the value of x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            double a1, a2, b1, b2;


            Console.WriteLine("Enter co-ordinates of second Line ");
            Console.WriteLine("Enter the value of a1:");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of a2:");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b1:");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b2:");
            b2 = Convert.ToDouble(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line" + length1);

            double length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("length of line" + length2);
            Console.WriteLine(length1.CompareTo(length2));
            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("length of line 1 is greater than line 2");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("length of line 1 is smaller tha line 2");

            }
            else
            {
                Console.WriteLine("both line are same in length");
            }
        }
    }
}
