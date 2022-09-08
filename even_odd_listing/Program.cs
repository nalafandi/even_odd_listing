namespace even_odd_listing
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter a positive Integer between 0 and 100: ");
                int x = int.Parse(Console.ReadLine());

                if (x > 100)
                {
                    Console.WriteLine("Stay under 100 ");
                }
                else
                {

                    Console.WriteLine("Enter 0 for Even series or 1 for Odd series");

                    int y = int.Parse(Console.ReadLine());

                    if (y == 0)
                    {
                        Console.WriteLine("You have selected the even series between 0 and " + x);

                        int i = 1;
                        int even = 0;
                        while (even <= x)
                        {

                            Console.WriteLine(even.ToString());
                            even = 2 * i;
                            i++;
                        }
                    }
                    else if (y == 1)
                    {
                        Console.WriteLine("You have selected the even series between 0 and " + x);

                        int i = 1;
                        int odd = 0;
                        while (odd <= x)
                        {

                            Console.WriteLine(odd.ToString());
                            odd = 2 * i + 1;
                            i++;
                        }
                    }
                }
            }

            catch
            {
                Console.WriteLine("Please enter integer values only and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
