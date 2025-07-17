using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
		[Required]
		public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre")]
        
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese una duración")]
        public int DuracionAnios { get; set; }
        [Required(ErrorMessage = "Ingrese un titulo")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "El Titulo debe estar entre 15 y 50 caracteres")]
        public string? TituloOtorgado { get; set; }
        [Required(ErrorMessage = "Eliga una modalidad")]
        public string? Modalidad { get; set; }
    }
}
