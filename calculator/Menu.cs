using NPOI.SS.Formula.Functions;

namespace calculator;

public class Menu
{
    public static List<string> History = new List<string>();
    public static void Calc(double a, double b, char c)
    {
        double result = Calculator.Calc(a, b, c);
        Console.WriteLine($"{a} {c} {b} = {result}");
        History.Add($"{a} {c} {b} = {result}");
    }


    public static double SquareRoot(double a)
    {
        if (a < 0)
        {
            Console.WriteLine("Không hợp lệ.");
            return 0;
        }
        else
        {
            double result = Math.Sqrt(a);
            Console.WriteLine("Kết quả là: {0}", a);
            History.Add($"Căn bậc 2 là: {a}");

            return result;
        }
    }
    public static double CubeRoot(double a)
    {
        if (a < 0)
        {
            Console.WriteLine("Không hợp lệ.");
            return 0;
        }
        else
        {
        double result = Math.Pow(a, 1.0 / 3);
        Console.WriteLine("Kết quả là: {0}", a);
            History.Add($"Căn bậc 3 là: {a}");

            return result;
    }
}
  
        public static void QuadraticEquation(double a, double b, double d)
        {
            double delta = b * b - 4 * a * d;

            if (delta < 0)
            {
                Console.WriteLine("Không tìm thấy nghiệm của phương trình! ");
            }
            else if (delta == 0)
            {
            double x = -b / (2 * a);
            Console.WriteLine("Phương trình có 1 nghiệm x = {0}", x);
            History.Add(string.Format("Phương trình có 1 nghiệm x = {0}", x));

        }
        else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm là: \n X1 = {0} \n X2 = {1}", x1, x2);
            History.Add(string.Format("Nghiệm của phương trình là:\n X1 = {0}\n X2 = {1}", x1, x2));  
        }
    }
    public static void CubicEquation(double a, double b, double c, double d)
    {
        double delta = b * b - 3 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Không tìm thấy nghiệm của phương trình! ");
            return;
        }
        else
        {

            double t1 = (-b + Math.Sqrt(delta)) / (3 * a);
            double t2 = (-b - Math.Sqrt(delta)) / (3 * a);

            double x1 = t1 - b / (3 * a);
            double x2 = t2 - b / (3 * a);
            double x3 = -t1 - t2 - b / (3 * a);

            Console.WriteLine("Phương trình có 3 nghiệm là: ");
            Console.WriteLine("x1 = ", x1);
            Console.WriteLine("x2 = ", x2);
            Console.WriteLine("x3 = ", x3);
            History.Add(string.Format("Nghiệm của phương trình là:\n X1 = {0}\n X2 = {1}\n X3 = {2} ", x1, x2, x3));
            return;
        }
    }



    public static void PrintHistory()
    {
        Console.WriteLine("Lịch sử giao dịch là: \n");
        if (Menu.History.Count == 0)
        {
            Console.WriteLine("Không có lịch sử giao dịch.");
        }
        else
        {
        foreach (string item in History)
            {
                Console.WriteLine(item);
            }
        }
    }
}


