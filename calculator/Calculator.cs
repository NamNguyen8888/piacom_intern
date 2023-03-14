using NPOI.SS.Formula.Functions;

namespace calculator;
public class Calculator
{
    public static double Calc(double a, double b, char c)
    {
        switch (c)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;
            default:
                throw new ArgumentException("Invalid operator.");
        }
       
    }

}


