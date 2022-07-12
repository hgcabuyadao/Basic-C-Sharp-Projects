using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string Currentday = Console.ReadLine();

                var Monday = DaysOfTheWeek.Monday;
                var dayMonday = Monday.ToString();

                var Tuesday = DaysOfTheWeek.Tuesday;
                var dayTues = Tuesday.ToString();

                var Wednesday = DaysOfTheWeek.Wednesday;
                var dayWed = Wednesday.ToString();

                var Thursday = DaysOfTheWeek.Thursday;
                var dayThur = Thursday.ToString();

                var Friday = DaysOfTheWeek.Friday;
                var dayFri = Friday.ToString();

                var Saturday = DaysOfTheWeek.Saturday;
                var daySat = Saturday.ToString();

                var Sunday = DaysOfTheWeek.Sunday;
                var daySun = Sunday.ToString();



                if (Currentday == dayMonday)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Monday);
                }

                else if (Currentday == dayTues)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Tuesday);
                }
                else if (Currentday == dayWed)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Wednesday);
                }
                else if (Currentday == dayThur)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Thursday);
                }
                else if (Currentday == dayFri)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Friday);
                }
                else if (Currentday == daySat)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Saturday);
                }
                else if (Currentday == daySun)
                {
                    Console.WriteLine((int)DaysOfTheWeek.Sunday);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
              
            }
            catch (FormatException ex)

            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();

        }
            }

        enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }


