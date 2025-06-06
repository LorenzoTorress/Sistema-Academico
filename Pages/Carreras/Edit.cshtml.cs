using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Data;
using System.Security.Cryptography.X509Certificates;
using SistemaAcademico.Helpers;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        public List<string> Modalidad { get; set; } = new();
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet(int id)
        {
            Modalidad = OpcionesModalidad.Lista;
            foreach (var c in DatosCompartidos.Carreras) 
            { 
                if (c.Id == id)
                    Carrera = c;
                break;
            }
        }
        public IActionResult OnPost()
        {
            Modalidad = OpcionesModalidad.Lista;
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
