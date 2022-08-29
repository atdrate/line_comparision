

namespace line_comparision
{
    internal class calculatelength
    {
        public static void lengthofline()
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

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line"+length);
        }
    }
}
