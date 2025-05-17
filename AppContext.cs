using Microsoft.EntityFrameworkCore;

namespace WinFormsExamTest2;

public class AppContext : DbContext
{
    public DbSet<Клиент> Клиенты { get; set; }
    public DbSet<Офис> Офисы { get; set; }
    public DbSet<Товар> Товары { get; set; }
    
    public AppContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../../../app.db");
    }
}