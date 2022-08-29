using line_comparision;

namespace linecomparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option \n1 calculate length \n2 check line equality \n3 check line equality by java method ");
         int opt=Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    calculatelength.lengthofline();
                        break;
                    case 2:
                    equalityoftwoline.equalornot();
                    break;
                case 3:
                    comparelinejava.linebycomparetomethod();
                    break;
            }
        }
    }
}