using Kiosko_Facturacion.Context;
using Kiosko_Facturacion.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kiosko_Facturacion.Controllers
{
    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
    //{
    //    _logger = logger;
    //}

    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ContextDB _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, ContextDB context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
