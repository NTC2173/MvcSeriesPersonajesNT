using Microsoft.EntityFrameworkCore;
using MvcSeriesPersonajesNT.Models;

namespace MvcSeriesPersonajesNT.Data
{
    public class SeriesContext:DbContext
    {
        //CONSTRUCTOR PARA RECIBIR CADENA DE CONEXION
        public SeriesContext(DbContextOptions<SeriesContext> options):base(options) { }

        //MAPEAR LAS CLASES MODEL DE LA BD
        public DbSet<Serie> Series { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        
    }
}
