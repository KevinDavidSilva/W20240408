using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W20240408.EntidadesDeNegocio;
using W20240408.LogicaDeNegocio;

namespace W20240408.UI.AppWebMVC.Controllers
{
    public class PersonaWController : Controller
    {
        readonly PersonaWBL _personaWBL;
        public PersonaWController(PersonaWBL personaWBL)
        {
            _personaWBL = personaWBL;

        }
        // GET: PersonaWController
        public async Task<IActionResult> Index(PersonaW persona)
        {
            var clientes = await _personaWBL.Buscar(persona);
            return View(clientes);
        }

        // GET: AlumnoController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var cliente = await _personaWBL.ObtenerPorId(new PersonaW { Id = id });
            return View(cliente);
        }

        // GET: AlumnoController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaW persona)
        {
            try
            {
                await _personaWBL.Crear(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await _personaWBL.ObtenerPorId(new PersonaW { Id = id });
            return View(cliente);
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PersonaW persona)
        {
            try
            {
                await _personaWBL.Modificar(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _personaWBL.ObtenerPorId(new PersonaW { Id = id });
            return View(cliente);
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(PersonaW persona)
        {
            try
            {
                await _personaWBL.Eliminar(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
