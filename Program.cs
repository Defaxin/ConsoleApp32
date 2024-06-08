namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-4 or 5 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("Choose:");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.Write("Input num: ");
                                int decimalNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Num: {NumberConverter.DecimalTo(decimalNumber)}");
                                break;
                            case 2:
                                Console.Write("Input num: ");
                                string binaryNumber = Console.ReadLine();
                                Console.WriteLine($"Num: {NumberConverter.ToDecimal(binaryNumber)}");
                                break;
                        }
                        break;
                    case 2:
                        ForeignPasport pas = new ForeignPasport();
                        pas.Passport("234567", "Name", "01.29.2001");
                        pas.ToString();
                        break;
                    case 3:

                        break;
                    case 4:
                        Console.Write("Input: ");
                        string input = Console.ReadLine();

                        try
                        {
                            bool result = Class1.Evaluate(input);
                            Console.WriteLine($"Result: {result}");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                        }
                        break;
                    case 5:
                        whil = 1;
                        break;
                }
            }
        }
    }
}
