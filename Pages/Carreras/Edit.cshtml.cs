using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Data;
using System.Security.Cryptography.X509Certificates;
using SistemaAcademico.Helpers;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        public List<string> Modalidad { get; set; } = new();
        [BindProperty]
        public Carrera? Carrera { get; set; }
        public void OnGet(int id)
        {
            Modalidad = OpcionesModalidad.Lista;

            Carrera? carrera = ServicesCareer.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }
        public IActionResult OnPost()
        {
            Modalidad = OpcionesModalidad.Lista;
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServicesCareer.EditarCarrera(Carrera);
            
            return RedirectToPage("Index");
        }
    }
}
