using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MongoDB_SQLServer
{
    public class Entidades
    {
        public class Persona
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Gender { get; set; }
            public ICollection<Funcion> Funciones { get; set; }
        }
        public class Pelicula
        {
            public int MovieId { get; set; }
            public string MovieTitle { get; set; }
            public string MovieGenres { get; set; }

            public ICollection<Funcion> Funciones { get; set; }
        }
        public class Funcion
        {
            public int FuncionId { get; set; }
            public DateTime Date { get; set; }
            public DateTime Time { get; set; }
            public decimal Price { get; set; }
            public int Seat { get; set; }
            public int CinemaRoom { get; set; }

            public int PersonId { get; set; }
            public Persona Persona { get; set; }

            public int MovieId { get; set; }
            public Pelicula Pelicula { get; set; }
        }

    }
}
