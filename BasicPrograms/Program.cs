﻿namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter 1 for Flip Coin");
            Console.WriteLine("Enter 2 for Leap Year");
            Console.WriteLine("Enter 3 for Power of Two");
            Console.WriteLine("Enter 4 for Harmonic Series");
            Console.WriteLine("Enter 5 for Prime Factors");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    FlipCoin Fc = new FlipCoin();
                    Fc.HeadsOrTailPercentage();
                    break;
                case 2:
                    LeapYear Ly = new LeapYear();
                    Ly.leapYear();
                    break;
                case 3:
                    PowerOFTwo Pf = new PowerOFTwo();
                    Pf.powOfTwo();
                    break;
                case 4:
                    HarmonicNumber Hn = new HarmonicNumber();
                    Hn.Harmonic();
                    break;
                case 5:
                    Factors primeFactors = new Factors();
                    primeFactors.PrimeFactors();
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}