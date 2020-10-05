using Microsoft.EntityFrameworkCore;
using System;
using Crismeyri_P1_AP1.Entidades;


namespace Crismeyri_P1_AP1.DAL{

public class Contexto:DbContext
{
    public DbSet <Ciudades> Ciudades {get; set;}
    
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=Ciudades.db");
        }

}
}