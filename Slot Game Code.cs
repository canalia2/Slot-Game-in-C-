using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nakov.IO;





    namespace Practice_Csharp
    {
    class Program
    {

        static void Main(string[] args)
        {
            const int plays = 10;
            int bet = 1;
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0;
            int payout = 0;
            double total = 0;
            int[] Reels = new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 5, 5, 7 };
            //Random r = new Random();

            //BetPrompt(ref bet);

            //Console.WriteLine("\nPress any key to play. ");
            //Console.ReadKey();

            for (int k = 0; k <= plays; k++)
            {
                Random r = new Random();

                ReelsGenerator(Reels, ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref i);


                /*  Console.WriteLine("+-------+");
                  Console.WriteLine("|" + a + "  " + b + "  " + c + "|");
                  Console.WriteLine("|" + d + "  " + e + "  " + f + "|");
                  Console.WriteLine("|" + g + "  " + h + "  " + i + "|");
                  Console.WriteLine("+-------+");
                  */
                if ((d == e) && (e == f))
                {
                    if (d == 7 && e == 7 && f == 7)
                    {
                        //Console.WriteLine("\nCongrats you got 3 sevens! ");
                        ThreeSevensPayout(ref payout, bet);
                    }
                    else if (d == 1 && e == 1 && f == 1)
                    {
                        //Console.WriteLine("\nCongrats you got 3 ones!");
                        ThreeOnesPayout(ref payout, bet);
                    }
                    else if (d == 2 && e == 2 && f == 2)
                    {
                        //Console.WriteLine("\nCongrats you got 3 twos!");
                        ThreeTwosPayout(ref payout, bet);
                    }
                    else if (d == 5 && e == 5 && f == 5)
                    {
                        //Console.WriteLine("\nCongrats you got 3 fives!");
                        ThreeFivesPayout(ref payout, bet);
                    }
                }
                else if ((d == 7 && e == 7 && f != 7) || (d == 7 && e != 7 && f == 7) || (d != 7 && e == 7 && e == 7))
                {
                    //Console.WriteLine("\nCongrats you got 2 sevens!");
                    TwoSevensPayout(ref payout, bet);
                }

                else if ((d == 7 && e != 7 && f != 7) || (d != 7 && e != 7 && f == 7) || (d != 7 && e == 7 && e != 7))
                {
                    //Console.WriteLine("\nCongrats you got 1 seven!");
                    OneSevenPayout(ref payout, bet);
                }

                else
                {
                    //Console.WriteLine("\nSorry you lose.");
                    LosingPayout(ref payout, bet);
                }

                total = total + payout;

            }
            Console.WriteLine("Payback Percentage is " + total / plays);
            
        }
     static void BetPrompt(ref int credit)
        {
            Console.Write("Would you like to bet 1 or 2 credits? ");
            credit = int.Parse(Console.ReadLine());
        }

     static void ReelsGenerator(int[] arr, ref int a, ref int b, ref int c, ref int d, ref int e, ref int f, ref int g, ref int h, ref int i)
        {
            Random r = new Random();
            for(int j = 0; j <= arr.Length; j++)
            {
                int index = r.Next(0, arr.Length);
                switch(j)
                {
                    case 0:
                        a = arr[index];
                        break;
                    case 1:
                        b = arr[index];
                        break;
                    case 2:
                        c = arr[index];
                        break;
                    case 3:
                        d = arr[index];
                        break;
                    case 4:
                        e = arr[index];
                        break;
                    case 5:
                        f = arr[index];
                        break;
                    case 6:
                        g = arr[index];
                        break;
                    case 7:
                        h = arr[index];
                        break;
                    case 8:
                        i = arr[index];
                        break;
                    default:
                        break;
                    
                }
            }
        }

        static void ThreeSevensPayout(ref int payout, int bet)
        {
            payout = bet * 20;
            Console.WriteLine("You won " + payout + " credits!");
        }
        
        static void TwoSevensPayout(ref int payout, int bet)
        {
            payout = bet * 7;
            Console.WriteLine("You won " + payout + " credits!");
        }
        
        static void OneSevenPayout(ref int payout, int bet)
        {
            payout = bet * 1;
            Console.WriteLine("You won " + payout + " credits!");
        }

       static void ThreeOnesPayout(ref int payout, int bet)
        {
            payout = bet * 5;
            Console.WriteLine("You won " + payout + " credits!");
        }

        static void ThreeTwosPayout(ref int payout, int bet)
        {
            payout = bet * 5;
            Console.WriteLine("You won " + payout + " credits!");
        }

        static void ThreeFivesPayout(ref int payout, int bet)
        {
            payout = bet * 10;
            Console.WriteLine("You won " + payout + " credits!");
        }

        static void LosingPayout(ref int payout, int bet)
        {
            payout = bet * 0;
           
        }

        static void PayoutCounter(ref double total, ref int payout, int bet)
        {
            total = total + payout;
        }





    }

    
}

