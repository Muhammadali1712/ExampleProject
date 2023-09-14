using Example.Application.Servise.Interfaces;
using Example.Domain.Models;
using Example.Infrastructura.DB;

namespace Example.Application.Servise.Classes;

public class ProgrammerCRUD : IProgrammerCRUD
{
    private static MyDbContext _dbContext;
    

    public ProgrammerCRUD()
    {
        _dbContext = new MyDbContext();
    }
    public void Create(Programmer programmer)
    {
        Console.Clear();
        Console.Write("Enter Name : ");
        programmer.Name = Console.ReadLine();
        Console.Write("Enter level (Junior,Middle,Senior) : ");
        programmer.Level = Console.ReadLine();
        Console.Write("How many apps does the developer have? : ");
        _dbContext.Programmers.Add(programmer);
        _dbContext.SaveChanges();
        //List<Programmer> programmerlist = _dbContext.Programmers.ToList();
        int count = Convert.ToInt32(Console.ReadLine());
        //ICollection<App> appList = new List<App>();
        for (int i = 0; i < count; i++)
        {
            App app = new App();
            Console.Write(i+1 + "-dastur nomini kiriting : ");
            app.Name = Console.ReadLine();
            Console.Write(app.Name + " dasturi tasnifi : ");
            app.Description = Console.ReadLine();
            app.ProgrammerId = _dbContext.Programmers.Where(p => p.Name.Equals(programmer.Name))
                .Select(p => p.Id).FirstOrDefault();
            _dbContext.Apps.Add(app);
        }
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        if(_dbContext.Programmers.Where(x => x.Id == id).Any())
        {
            _dbContext.Programmers.Remove(GetById(id));
            _dbContext.SaveChanges();
            Console.WriteLine("O'chirildi");
        }
        else Console.WriteLine("topilmadi");
    }

    public void GetAll()
    {
        Console.Clear ();
        List<Programmer> plist = _dbContext.Programmers.ToList();
        List<App> alist = _dbContext.Apps.ToList();

        foreach (var p in plist)
        {
            Console.WriteLine("Id : "+p.Id+"  Programmer : "+p.Name+"    Level : "+p.Level);
            Console.Write("Apps : ");
            int count = 0;
            foreach (var app in alist)
            {
                if(app.ProgrammerId == p.Id)
                {
                    Console.Write(app.Name+",  ");
                    count++;
                }
            }
            if(count == 0) Console.WriteLine("No Apps");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public Programmer GetById(int id)
    {
        
        return _dbContext.Programmers.FirstOrDefault(x => x.Id == id);
        
    }

    public void Update(int id)
    {
        if (_dbContext.Programmers.Where(x => x.Id == id).Any())
        {
            Programmer programmer = GetById(id);
            Console.Write("Enter Name : ");
            programmer.Name = Console.ReadLine();
            Console.Write("Enter level (Junior,Middle,Senior) : ");
            programmer.Level = Console.ReadLine();

            /*Console.Write("How many apps does the developer have? : ");

            //_dbContext.Programmers.Add(programmer);
            
            //List<Programmer> programmerlist = _dbContext.Programmers.ToList();
            int count = Convert.ToInt32(Console.ReadLine());
            //ICollection<App> appList = new List<App>();
            for (int i = 0; i < count; i++)
            {
                App app = new App();
                Console.Write(i + 1 + "-dastur nomini kiriting : ");
                app.Name = Console.ReadLine();
                Console.Write(app.Name + " dasturi tasnifi : ");
                app.Description = Console.ReadLine();
                app.ProgrammerId = _dbContext.Programmers.Where(p => p.Name.Equals(programmer.Name))
                    .Select(p => p.Id).FirstOrDefault();
                //_dbContext.Apps.Add(app);
            }*/
            _dbContext.SaveChanges();
            Console.WriteLine("Updated!!!");
        }
        else Console.WriteLine("topilmadi");
    }


    public App GetAppById(int id)
    {
        return _dbContext.Apps.FirstOrDefault(x => x.Id == id);
    }

   
}
