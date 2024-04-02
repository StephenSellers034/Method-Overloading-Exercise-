namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Add(double x, double y)
        {
            double sum = x + y;
            return Convert.ToInt32(x + y);
        }

        public static int Add(decimal a, decimal b)
        {
            decimal sum = a + b;
            return Convert.ToInt32(a + b);

        }

        public static string Add(int num1, int num2, bool isNum)
        {
            int sum = num1 + num2;
            if (isNum == true && sum > 1)
            {
                  return $"{sum} dollars";
            }
            else if (isNum == true && sum == 1)
            {
                  return $"{sum} dollar";
            }
            else
            {
                  return sum.ToString();
            }
            
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(20.06m, 17.23m));
            Console.WriteLine(Add(9.5, 4.6));
            Console.WriteLine(Add(11, 7, true));
        }
    }
}
