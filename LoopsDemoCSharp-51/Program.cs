namespace LoopsDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //While loop
        Console.WriteLine("WHILE LOOP:");

        var cont = "yes";
        
        while (cont == "yes")
        {
            Console.WriteLine("Continue? (Type 'yes' or 'no'");
            cont = Console.ReadLine().ToLower();
        }

        var number = 0;

        while (number <= 5)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("Continue on..");
        
        //do while loop
        Console.WriteLine("DO WHILE LOOP:");

        var otherNumber = 0;
        
        do
        {
            Console.WriteLine(otherNumber);
            otherNumber++;
        } while (otherNumber <= 10);
        
        //for loop
        Console.WriteLine("FOR LOOP:");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        for (int i = 3; i <= 999; i += 3)
        {
            Console.WriteLine(i);
        }
        
        //foreach
        Console.WriteLine("FOREACH LOOP:");

        var numbers = new int[] { 22, 44, 556, 78, 12, 2 };

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
