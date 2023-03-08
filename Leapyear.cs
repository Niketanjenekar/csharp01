namespace Program1
{
    public class Leapyear
        {
        public static void PrintLeapyear()
        {
            Console.WriteLine("Please entre the year ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The year you entered is " + num);

            int num1 = num % 4;

            if (num1 == 0)
            {
                Console.WriteLine("The year entered is the leap year");
            }
            else
            {
                Console.WriteLine("The year you entered is not the leap year");
            }
        }
    }           
}