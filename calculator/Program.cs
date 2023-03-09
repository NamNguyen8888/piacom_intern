using calculator;
using System;
using NPOI.SS.Formula.Functions;



double a = 0, b = 0, result = 0;
    while (true)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Chọn Menu:");

        Console.WriteLine("1. Cộng");
        Console.WriteLine("2. Trừ");
        Console.WriteLine("3. Nhân");
        Console.WriteLine("4. Chia");
        Console.WriteLine("5. Căn bậc 2");
        Console.WriteLine("6. Căn bậc 3");
        Console.WriteLine("7. Giải phương trình bậc 2");
        Console.WriteLine("8. Giải phương trình bậc 3");
        Console.WriteLine("9. Hiển thị tất cả lịch sử giao dịch");
        Console.WriteLine("0. Thoát");
        Console.Write("Chọn Menu: ");
    int choice = int.Parse(Console.ReadLine());
   

    if(choice!= 9 && choice != 5 && choice != 6 && choice != 7 && choice != 8)
    {
        Console.WriteLine("Nhập số đầu tiên: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số thứ 2: ");
        b = Convert.ToDouble(Console.ReadLine());
        if (choice == 0)
        {
            break;
        }
    }
    switch (choice)
    {
        case 1:
            Menu.Calc(a, b, '+');
            break;
        case 2:
            Menu.Calc(a, b, '-');
            break;
        case 3:
            Menu.Calc(a, b, '*');
            break;
        case 4:
            Menu.Calc(a, b, '/');
            break;
        case 5:
            Console.Write("Nhập số tính căn bậc 2: ");
            a = double.Parse(Console.ReadLine());
            result = Math.Sqrt(a);
            Menu.SquareRoot(result);
            break;
        case 6:
            Console.Write("Nhập số tính căn bậc 3: ");
            a = double.Parse(Console.ReadLine());
            result = Math.Pow(a, 1.0 / 3);
            Menu.CubeRoot(result);
            break;
        case 7:
            Console.Write("Nhập số a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số c: ");
            double d = double.Parse(Console.ReadLine());
            Menu.QuadraticEquation(a, b, d);
            break;
        case 8:
        Console.WriteLine("Nhập phương trình bậc 3 có định dạng là: ax^3 + bx^2 + cx + d = 0");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            d = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 3 * a * c;
            Menu.CubicEquation(a, b, c, d);

            break;

        case 9:
            Menu.PrintHistory();
            break;
        default:
            Console.WriteLine("Không chọn đúng!");
            break;
    }
    // Hiển thị thông báo hỏi người dùng 
    Console.Write("Bạn có muốn tiếp tục tính toán? (Y/N): ");
            string Choice = Console.ReadLine();

            if (Choice == "Y" || Choice == "y")
            {
                // Nếu người dùng muốn tiếp tục, quay lại menu chính
                Console.Clear();
            }
            else
            {
                //kết thúc chương trình
                Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                Environment.Exit(0);
            }
}

