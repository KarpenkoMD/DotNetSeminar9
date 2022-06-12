/* Задача 69: 
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

 class Program {
  public static (double, double) GetNumbers()
  {
    double number =0,  pow =0;
    Console.Write("Введите число, которое необходимо возвести в степень: ");
    number = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите степень, в которую необходимо возвести число {0}: ", Math.Round(number,0));
    pow = Convert.ToDouble(Console.ReadLine());
    return (number, pow);
  }
  public static double NumberPow(double num, double pow)
  {
    double result = num;
    if (pow == 0) return 1;
    if (pow == 1) return result;
    return result*NumberPow(result,pow-1);
  }
  public static void Main ()
  {
    double numberToPow = 0, power =0;
    double result = 0; 
    (numberToPow, power) = GetNumbers();
    result = NumberPow(numberToPow, power);
    Console.WriteLine("Число {0} в степени {1} = {2}. ", Math.Round(numberToPow,0), Math.Round(power,0), Math.Round(result,0));
  }
}