using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEqnRootsCal
{
    public class QuadraticEqn
    {
        public static int a;
        public static int b;
        public static int c;
        public static double delta;
        public QuadraticEqn(int x, int y, int z)
        {
            a = x;
            b = y;
            c = z;
            delta = CalDelta(); 
        }

        public double CalDelta()
        {
            return Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
        }
        public List<double> RootsCalculator()
        {   
            if (delta > 0)
            {              
                return CalTwoRoots();
            }
            else if (delta == 0)
            {
                return CalOneRoot();
            }
            else
            {
                return new List<double> { 0 };
            }

        }

        public List<double> CalTwoRoots()
        {
            
            double root1 = (-b + delta) / (2 * a);
            double root2 = (-b - delta) / (2 * a);

            return new List<double> { root1, root2};
        }

        public List<double> CalOneRoot()
        {
            double root = (-b / (2 * a));
            return new List<double> { root };
        }
    }
}
