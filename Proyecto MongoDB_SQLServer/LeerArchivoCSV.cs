using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Proyecto_MongoDB_SQLServer;
using static Proyecto_MongoDB_SQLServer.Entidades;

public class CsvToSqlImporter
{
    private readonly CinemaKinoContext _dbContext;

    public CsvToSqlImporter(CinemaKinoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void ImportarDesdeCsv(string rutaCsv)
    {
        using (StreamReader reader = new StreamReader(rutaCsv))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] valores = linea.Split(',');

                var persona = new Persona
                {
                    FirstName = valores[1],
                    LastName = valores[2],
                    Email = valores[3],
                    Phone = valores[4],
                    Gender = valores[5]
                };

                var pelicula = new Pelicula
                {
                    MovieTitle = valores[7],
                    MovieGenres = valores[6]
                };

                var funcion = new Funcion
                {
                    Date = DateTime.Parse(valores[8]),
                    Time = DateTime.Parse(valores[9]),
                    Price = decimal.Parse(valores[10]),
                    Seat = int.Parse(valores[11]),
                    CinemaRoom = int.Parse(valores[12]),
                    Persona = persona,
                    Pelicula = pelicula
                };

                _dbContext.Personas.Add(persona);
                _dbContext.Peliculas.Add(pelicula);
                _dbContext.Funciones.Add(funcion);
            }
        }
        _dbContext.SaveChanges();
        {
            //using var dbContext = new CinemaKinoContext();
            //var importer = new CsvToSqlImporter(dbContext);


            //importer.ImportarDesdeCsv(@"C:\Users\artur\source\repos\Proyecto MongoDB_SQLServer\Proyecto MongoDB_SQLServer\Archivo\MOCK_DATA.csv");
        }
    }
}

