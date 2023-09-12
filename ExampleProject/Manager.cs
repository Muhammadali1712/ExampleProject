using Example.Application.Servise.Classes;
using Example.Domain.Models;

namespace ExampleProject.Prezentation
{
    public class Manager
    {
       public static ProgrammerCRUD crud = new ProgrammerCRUD();
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
                Console.WriteLine("2. GetAll");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. GetById");
                Console.WriteLine("6. ");
                Console.WriteLine("7. ");
                Console.WriteLine("0. Exit");
                Console.Write("Tanlang: ");
                int Select = Convert.ToInt32(Console.ReadLine());
                switch (Select)
                {
                    case 0: davom = false; break;
                    case 1:
                        Programmer programmer = new Programmer();
                        crud.Create(programmer);
                        break;
                    case 2:
                        crud.GetAll();
                        break;
                    case 3:
                       
                        break;
                    case 4:
                        Console.Write("Enter id : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        crud.Delete(n);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Enter id : ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Programmer programmer1 =  crud.GetById(x);
                        Console.WriteLine(programmer1.Name);
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
}
