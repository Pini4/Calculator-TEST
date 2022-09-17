internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число");

        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(@"Выберите действие , которое должен выполнить калькулятор:
1 - сложить,
2 - вычесть,
3 - умножить,
4 - делить,
5 - синус,
6 - косинус,
7 - тангенс,
8 - квадратный корень,
9 - степень.");



        string action = Console.ReadLine();
        switch (action)
        {
            case "1":
                Console.WriteLine(a + b);
                break;

             case "2":
                Console.WriteLine(a - b);
                break;

            case "3":
                Console.WriteLine(a * b);
                break;

            case "4":
                if (b == 0)
                {
                    Console.WriteLine("Дурак, на ноль делить нельзя");
                    break;
                }
                else
                {
                    Console.WriteLine(a / b);
                    break;
                }

            case "5":
                Console.Write("Укажите число , синус которого хотите узнать: ");
                Console.WriteLine(Math.Sin(double.Parse(Console.ReadLine())));
                break;

            case "6":
                Console.Write("Укажите число , косинус которого хотите узнать: ");
                Console.WriteLine(Math.Cos(double.Parse(Console.ReadLine())));
                break;

            case "7":
                Console.Write("Укажите число , тангенс которого хотите узнать: ");
                Console.WriteLine(Math.Tan(double.Parse(Console.ReadLine())));
                break;

            case "8":
                Console.Write("Укажите число , квадратный корень которого хотите узнать: ");
                Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));
                break;
            case "9":
                Console.Write("Укажите число и степень через запятую: ");
                string powinfo = Console.ReadLine();
                var powsplit = powinfo.Split(',');
                if (powsplit.Count() == 2)
                {
                    double n = double.Parse(powsplit[0].Trim());
                    double m = double.Parse(powsplit[1].Trim());
                    Console.WriteLine(Math.Pow(n, m));
                }
                else
                    Console.WriteLine("Вы ввели неправильные значения");
                break;
            default:
                
                Console.WriteLine("Неверное действие");
                return;
                

        }

        /*if (enter_key == '+')
        {
            Console.WriteLine(a + b);
        }
        else if (enter_key == '-')
        {
            Console.WriteLine(a - b);
        }
        else if (enter_key == '*')
        {
            Console.WriteLine(a * b);
        }
        else if (enter_key == '/')
        {
            Console.WriteLine(a / b);

            if (b == 0)
            {
                Console.WriteLine("Дурак, на ноль делить нельзя");
            }
        }
        Console.WriteLine("Если вы хотите найти синус или косинус , тангенс , квадратный корень , введите число");
        double x = Convert.ToDouble(Console.ReadLine());
        double sin = Math.Sin(x);
        double cos = Math.Cos(x);
        double sqrt = Math.Sqrt(x);
        double tan = Math.Tan(x);
        Console.WriteLine($"Синус числа {x} равен {sin}. Если вы искали Косинус ,то он равен {cos}. Квадратный корень числа {x} равен {sqrt}.А тангенс этого числа равен {tan}");
        Console.WriteLine("Если вы хотите возвести число в степень , то введите число");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите в какой степени должно быть число");
        double v = Convert.ToDouble(Console.ReadLine());
        double m = Math.Pow(w, v);
        Console.WriteLine($" Число {w} в степени {v} равно {m}");
        */
    }
}