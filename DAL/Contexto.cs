using Microsoft.EntityFrameworkCore;
using System;
using Crismeyri-P1-AP1.Entidades;


namespace Crismeyri-P1-AP1.DAL{

public class Contexto:DbContext
{
    public DbSet <Ciudades> Ciudad {get; set;}
    
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=Ciudades.db");
        }

}
}