using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Data;
using System.Security.Cryptography.X509Certificates;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet(int id)
        {
            foreach (var c in DatosCompartidos.Carreras) 
            { 
                if (c.Id == id)
                    Carrera = c;
                break;
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var c in DatosCompartidos.Carreras)
            {
                c.Nombre = Carrera.Nombre;
                c.DuracionAnios = Carrera.DuracionAnios;
                c.TituloOtorgado = Carrera.TituloOtorgado;
                c.Modalidad = Carrera.Modalidad;
                break;
            }
            return RedirectToPage("Index");
        }
    }
}
