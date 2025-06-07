using SistemaAcademico.Models;
using System.Text.Json;

namespace SistemaAcademico.Services
{
    public class ServicesCareer
    {
        private static string ruta = "/Data/Career.json";
        public static string LeerArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return "[]";
        }
        public static List<Carrera> ObtenerCarreras()
        { 
            string json = LeerArchivo();
            var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
            return lista ?? new List<Carrera>();
        }
        public static void AgregarCarrera(Carrera nuevaCarrera)
        {
            var carrera = ObtenerCarreras();
            nuevaCarrera.Id = ObtenerNuevoID(Carrera);
            carrera.Add(nuevaCarrera);
            GuardarCarrera(carrera);


        }
        public static int ObtenerId()
        {
            var carrera = ObtenerCarreras();
            int Id = 0;
            Id = carrera.Last;
        }
    }
}
