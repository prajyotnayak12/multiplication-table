

class MUL
{
    public static void Main()
    {
        Console.Write("ENTER THE NUMBER WHOSE MULTIPLICATIN TABLE U WANT:"); 
        int n = Convert.ToInt64(Console.ReadLine());
        if (n > 0 && n < 100)
        {
            for (int i = 1; i <= 20; ++i)
            {
                Console.Write(n + " * " + i + " = " + n * i + "\n" );

            }
        }
        else
        {
            Console.WriteLine("ERROR");
        }
        Console.ReadLine();
    }
}



