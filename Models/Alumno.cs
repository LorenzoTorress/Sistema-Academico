using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
	public class Alumno
	{
		[Required]
		public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido {  get; set; }
        [Required]
        public string? Dni { get; set; }
        [Required]
        public string? Email {  get; set; }
        [Required]
        public int FechaDeNacimiento {  get; set; }
	}
}
