using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Proyecto_MongoDB_SQLServer.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


namespace Proyecto_MongoDB_SQLServer
{
    
        public class CinemaKinoContext : DbContext
        {
            public DbSet<Persona> Personas { get; set; }
            public DbSet<Pelicula> Peliculas { get; set; }
            public DbSet<Funcion> Funciones { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=CinemaKino;Trusted_Connection=True;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {


                modelBuilder.Entity<Funcion>()
                    .HasOne(f => f.Persona)
                    .WithMany(p => p.Funciones)
                    .HasForeignKey(f => f.PersonId);

                modelBuilder.Entity<Funcion>()
                    .HasOne(f => f.Pelicula)
                    .WithMany(m => m.Funciones)
                    .HasForeignKey(f => f.MovieId);
            }
        }
    }
