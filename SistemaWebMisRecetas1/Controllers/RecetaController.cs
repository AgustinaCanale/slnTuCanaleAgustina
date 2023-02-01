using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas1.Data;
using SistemaWebMisRecetas1.Models;
using System.Linq;
using System.Reflection.Metadata;

namespace SistemaWebMisRecetas1.Controllers
{
    public class RecetaController : Controller
    {

        private readonly DBDesayunoContext context;

        public RecetaController(DBDesayunoContext context)
        {
            this.context = context;

        }

        //Traer una
        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }

        [HttpGet]
        
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View("Index", recetas);
        }



        //getautor
        [HttpGet]
        public IActionResult RecetaAutor(string autor)
        {
            var recetasAutor = (from rec in context.Recetas where rec.Autor == autor select rec).ToList();

            return View("Index", recetasAutor);
        }




        //getapellido
        [HttpGet]
        public IActionResult RecetaApellido(string apellido)
        {
            var recetasApellido = (from rec in context.Recetas where rec.Apellido == apellido select rec).ToList();

            return View("Index", recetasApellido);
        }




        //DETALLE GET
        [HttpGet]
        public ActionResult Detalle(int id)
        {
            Receta receta = TraerUna(id);

            if (receta == null)
            {
                return NotFound();
            }

            return View("Detalle", receta);
        }


        //create
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create");
        }

        
        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Create", receta);
        }


    }
}




    




