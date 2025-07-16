using SistemaAcademico.Models;
using System.Text.Json;
using System.Xml.Linq;

namespace SistemaAcademico.Services
{
	public class ServicesStudent
	{
		private static string ruta = "/Data/Career.json";
		public static string LeerTextoDelArchivo()
		{
			if (File.Exists(ruta))
			{
				return File.ReadAllText(ruta);
			}
			return "[]";
		}
		public static List<Alumno> ObtenerAlumnos()
		{
			string json = LeerTextoDelArchivo();

			var lista = JsonSerializer.Deserialize<List<Alumno>>(json);
			return lista ?? new List<Alumno>();
		}
		public static void AgregarAlumno(Alumno nuevoAlumno)
		{
			var alumnos = ObtenerAlumnos();
			nuevoAlumno.Id = ObtenerNuevoId(alumnos);
			alumnos.Add(nuevoAlumno);
			GuardarAlumnos(alumnos);
		}
		public static int ObtenerNuevoId(List<Alumno>alumnos)
		{
			int maxId = 0;
			foreach (var alumno in alumnos)
			{
				if (alumno.Id > maxId)
				{
					maxId = alumno.Id;
				}
			}
			return maxId + 1;
		}
		public static void GuardarAlumnos(List<Alumno> alumnos)
		{
			string TextoJson = JsonSerializer.Serialize(alumnos);
			File.WriteAllText(ruta, TextoJson);
		}
		public static Alumno? BuscarPorId(int id)
		{
			var alumnos = ObtenerAlumnos();
			return BuscarAlumnosPorId(alumnos, id);
		}
		public static void EliminarPorId(int id)
		{
			var lista = ObtenerAlumnos();
			var alumnoAEliminar = BuscarAlumnosPorId(lista, id);

			if (alumnoAEliminar != null)
			{
				lista.Remove(alumnoAEliminar);
				GuardarAlumnos(lista);
			}
		}
		public static void EditarCarrera(Alumno alumnoEditado)
		{
			var lista = ObtenerAlumnos();
			var alumno = BuscarAlumnosPorId(lista, alumnoEditado.Id);
			if (alumno != null)
			{
				alumno.Nombre = alumnoEditado.Nombre;
				alumno.Apellido = alumnoEditado.Apellido;
				alumno.Dni = alumnoEditado.Dni;
				alumno.Email = alumnoEditado.Email;
				alumno.FechaDeNacimiento = alumnoEditado.FechaDeNacimiento;

				GuardarAlumnos(lista);
			}

		}
		private static Alumno? BuscarAlumnosPorId(List<Alumno> lista, int id)
		{
			foreach (var c in lista)
			{
				if (c.Id == id)
				{
					return c;
				}
			}
			return null;
		}

	}
}
