using MvcSeriesPersonajesNT.Data;
using MvcSeriesPersonajesNT.Models;

namespace MvcSeriesPersonajesNT.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        //CREAMOS LOS METODOS

        //MUESTRA LISTA SERIES
        public List<Serie> GetSeries()
        {
            var consulta = from datos in this.context.Series select datos;

            return consulta.ToList();
        }

        //MUESTRA UNA SERIE POR SU ID
        public Serie FindSerie(int id)
        {
            var consulta = from datos in this.context.Series where datos.IdSerie == id select datos;

            return consulta.FirstOrDefault();
        }

        //METODO PARA INSERTAR SERIE
        public void InsertarSerie(int id, string nombre, string imagen, int anyo)
        {
            Serie serie = new Serie();
            serie.IdSerie = id;
            serie.Nombre = nombre;
            serie.Imagen = imagen;
            serie.Anyo = anyo;

            this.context.Series.Add(serie);
            this.context.SaveChanges();

        }

        //METODO PARA MOSTRAR PERSONAJES DE UNA SERIE
        public List<Personaje>GetPersonajes(int id)
        {
            var consulta = from datos in this.context.Personajes select datos;

            return consulta.ToList();
        }
            

    }
}
