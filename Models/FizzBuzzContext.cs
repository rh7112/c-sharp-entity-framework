using Microsoft.EntityFrameworkCore;

namespace FizzBuzzApiEF;

public class FizzBuzzContext : DbContext // DbContext is the database
{
    public FizzBuzzContext(DbContextOptions<FizzBuzzContext> options)
        : base(options)
    {
    }

    public DbSet<FizzBuzzItem> Items { get; set; } = null!; // DbSet is the table, Items are the columns, basically. 

    // You would need a DbSet per table in your database
    // ORM = Object Relational Mapping
    // Object is FizzBuzzItem, the mapper is FizzBuzzContext

}

// dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
// dontnet add package Microsoft.EntityFrameworkCore.Design
// dotnet add package Microsoft.EntityFrameworkCore.InMemory
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer