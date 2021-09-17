using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            Console.WriteLine("What is your name?\n");
            person.name = Console.ReadLine();

            Console.WriteLine("\nHi " + person.name + "! Where are you from?\n");
            person.location = Console.ReadLine();

            Console.WriteLine("\nI have never been to " + person.location + ". I bet it is nice. \nPress any key to continue...");
            Console.ReadKey();
        }

        private static void ChristmasCountdown(DateTime date)
        {
            String month;
            int daysUntilChristmas;
            DateTime christmas = new DateTime(date.Year, 12, 25);

            switch(date.Month)
            {
                case 1:
                    month = "January";
                    break;

                case 2:
                    month = "February";
                    break;

                case 3:
                    month = "March";
                    break;

                case 4:
                    month = "April";
                    break;

                case 5:
                    month = "May";
                    break;

                case 6:
                    month = "June";
                    break;

                case 7:
                    month = "July";
                    break;

                case 8:
                    month = "August";
                    break;

                case 9:
                    month = "September";
                    break;

                case 10:
                    month = "October";
                    break;

                case 11:
                    month = "November";
                    break;

                case 12:
                    month = "December";
                    break;

                default:
                    month = "";
                    break;
            }

            daysUntilChristmas = (christmas - date).Days;
            Console.WriteLine("\nToday's date is: " + month + " " + date.Day + ", " + date.Year);
            Console.WriteLine("\nThere are " + daysUntilChristmas + " days until Christmas!\nPress any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();

            Console.WriteLine("Press any key to close finish the program.");
            Console.ReadKey();
        }
    }
}
