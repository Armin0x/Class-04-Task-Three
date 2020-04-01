using System;

namespace Class_04_Task_Three
{
    class Program
    {
        static int AgeCalculator()
        {
            DateTime calculate;
            int yearsOld;

            DateTime today = DateTime.Now;
            calculate = InputBirthday();
            if (calculate.Month < today.Month)
            {
                yearsOld = today.Year - calculate.Year - 1;
                Console.WriteLine($"You are {yearsOld} old. You will be {yearsOld + 1} this year.");
                return yearsOld;
            }
            else
            {
                yearsOld = today.Year - calculate.Year;
                Console.WriteLine($"You are {yearsOld} old. You already had you birthday.");
                return yearsOld;
            }

        }

        static DateTime InputBirthday()
        {
            bool checkDate;
            DateTime birthday;
            while (true)
            {
                Console.WriteLine("Enter your birthday in the following format  MM/dd/yyyy");
                string bday = Console.ReadLine();
                checkDate = DateTime.TryParse(bday, out birthday);

                if (checkDate)
                {
                    return birthday;
                }
                else
                {
                    Console.WriteLine("Try again to input a valid date format");
                }
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine(AgeCalculator());
            Console.ReadLine();
        }
    }
}
