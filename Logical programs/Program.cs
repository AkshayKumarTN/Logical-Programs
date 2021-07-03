using System;

namespace Logicalprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.Day Of Week");
            Console.WriteLine("2.Temperatur Conversion");
            Console.WriteLine("3.Monthly Payment");
            Console.WriteLine("4.Square Root");
            Console.WriteLine("5.Decimal To Binary Conversion");
            Console.WriteLine("6.Simulate Stopwatch");
            Console.WriteLine("7.Coupon Numbers");
            Console.WriteLine("8.Binary");
            Console.Write("Enter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    DayOfWeek.Readinput();
                    break;
                case 2:
                    TemperaturConversion.Readinput();
                    break;
                case 3:
                    MonthlyPayment.Readinput();
                    break;
                case 4:
                    SquareRoot.Readinput();
                    break;
                case 5:
                    ToBinary.Readinput();
                    break;
                case 6:
                    SimulateStopwatch.Readinput();
                    break;
                case 7:
                    CouponNumbers.Readinput();
                    break;
                case 8:
                    Binary.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
        }
    }
}
