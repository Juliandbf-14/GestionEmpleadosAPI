using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmpleadosAPI.Entities
{
    public class Empleado
    {
        public int Id { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Cargo { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Area { get; set; }
    }
}