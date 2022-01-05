using Microsoft.EntityFrameworkCore;
using C4WebApi.Models;
public class TeamContext: DbContext
{
    public TeamContext(DbContextOptions<TeamContext> options): base(options){}
    public DbSet <Team> Teams{ get; set;}
}