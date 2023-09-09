namespace Example.Application.Manager;

public class ExampleManager
{

    public static void Run()
    {
        Console.WriteLine("Welcome my Program!!!!");
        //_bookCRUDService = new BookCRUDservise();
        bool davom = true;
        while (davom)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("0. Exit");
            Console.Write("Tanlang: ");
            int Select = Convert.ToInt32(Console.ReadLine());
            switch (Select)
            {
                case 0: davom = false; break;
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7: break;
                default:
                    Console.WriteLine("Wrong Number!!!"); break;
            }
        }
    }
}
