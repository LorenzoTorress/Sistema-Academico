﻿using SistemaAcademico.Models;
using SistemaAcademico;

namespace SistemaAcademico.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        public static List<Alumno> Alumnos { get; set; } = new();
        private static int ultimoId = 0;
        public static int ObtenerID()
        {
            ultimoId++;
            return ultimoId;
        }
    }
}
