/* 
This program checks whether a given integer number is a prime number or not.
It takes an integer input from the user and evaluates its primality using 
conditional statements and a loop.
*/

class PrimeNum_Verification
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type an integer number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("This isn't a prime number.");
        }
        else if (num == 1)
        {
            Console.WriteLine("This isn't a prime number.");
        }
        else if (num == 2)
        {
            Console.WriteLine("This is a prime number.");
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("This isn't a prime number.");

                }
                else
                {
                    Console.WriteLine("This is a prime number.");

                }
                break;
            }
        }



    }


}