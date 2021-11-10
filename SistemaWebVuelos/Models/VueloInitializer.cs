using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace SistemaWebVuelos.Models
{
    public class VueloInitializer : DropCreateDatabaseAlways<VueloDbContext>
    {
        protected override void Seed(VueloDbContext context)
        {
            var vuelos = new List<Vuelo>
            {
                new Vuelo
                {
                    Fecha = new DateTime(2021, 12, 10),
                    Destino = "Bariloche",
                    Origen = "Buenos Aires",
                    Matricula = 121
                },
                new Vuelo
                {
                    Fecha = new DateTime(2022, 01, 2),
                    Destino = "Roma",
                    Origen = "Cordoba",
                    Matricula = 245
                },
                new Vuelo
                {
                    Fecha = new DateTime(2022, 4, 5),
                    Destino = "Peru",
                    Origen = "Tierra del Fuego",
                    Matricula = 988
                },
                
            };
            vuelos.ForEach(s => context.Vuelos.Add(s));
            context.SaveChanges();
        }
    }
}