using Microsoft.EntityFrameworkCore;

namespace Example.Infrastructura.DB;

public class MyDbContext:DbContext
{
    public MyDbContext()
    {
        //Database.EnsureCreated();
    }

    public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
    {
        
    }

    //public DbSet<Model> models { get; set; }
    //public DbSet<Model> models { get; set; }
    //public DbSet<Model> models { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=::1; Port=5432; Database=postgres; user id=postgres; password=2004-12-17");
    }
}
