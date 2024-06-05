using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Data;

public class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> dbContextOptions) : base (dbContextOptions)
    {

    }

    public DbSet<Member> Members {get; set;}
    public DbSet<Resource> Resourcess {get; set;}
    public DbSet<Visit> Visits {get; set;}

}