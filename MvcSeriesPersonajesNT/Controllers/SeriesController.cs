using Microsoft.AspNetCore.Mvc;
using MvcSeriesPersonajesNT.Models;
using MvcSeriesPersonajesNT.Repositories;

namespace MvcSeriesPersonajesNT.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Serie> series = this.repo.GetSeries();
            return View(series);
        }

        public IActionResult Detalles(int id)
        {
            Serie serie = this.repo.FindSerie(id);
            return View(serie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Serie series)
        {
            this.repo.InsertarSerie(series.IdSerie, series.Nombre, series.Imagen, series.Anyo);
            return RedirectToAction("Index");
        }

        public ActionResult Personajes(int id)
        {
            List<Personaje> personajes = this.repo.GetPersonajes(id);
            return View(personajes);
        }
     
    }
}
