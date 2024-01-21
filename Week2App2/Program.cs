namespace Week2App2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to my project");
            Console.WriteLine(" Day number for result ");

            int daynumber =int.Parse( Console.ReadLine());
            if (daynumber == 1) {
                Console.WriteLine("Watching film");

            }
            else if (daynumber == 2)
            {
                Console.WriteLine("go to sport");
            }
            else if (daynumber == 3) {
                Console.WriteLine("do assigment");

            }
            else if (daynumber == 4)
            {
                Console.WriteLine("go shopping");

            }
            else if (daynumber == 5)
            {
                Console.WriteLine("sleeping");

            }
            else if (daynumber == 6)
            {
                Console.WriteLine("go to Code Academy");

            }
            else if (daynumber == 7)
            {
                Console.WriteLine("go to academy");

            }
            else {
                Console.WriteLine("please enter correct day");
                    }

        }
    }
}