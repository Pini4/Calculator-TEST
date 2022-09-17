internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число");

        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введи действие , которое должен выполнить калькулятор");

        var enter = Console.ReadKey();
        char enter_key = enter.KeyChar;

        if (enter_key == '+')
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

    }
}