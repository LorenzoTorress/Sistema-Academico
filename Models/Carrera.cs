using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
		[Required]
		public int Id { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        public int DuracionAnios { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        [Range(1,7 , ErrorMessage ="La duraciòn es entre 1 a 7 años")]
        public string? TituloOtorgado { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        [StringLength(50 , MinimumLength = 15 , ErrorMessage ="El Titulo debe estar entre 15 y 50 caracteres")]
        public string? Modalidad { get; set; }
    }
}
