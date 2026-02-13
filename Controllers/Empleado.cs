using GestionEmpleadosAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmpleadosAPI.Controllers
{
    [Route("empleado/[controller]")]
    public class EmpleadoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmpleadoController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public async Task<object> IngresarEmpleado([FromBody] Empleado empleado){
            try
            {
                _context.Empleados.Add(empleado);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Ocurrió un error interno en el servidor");
            }
        }
    }
}