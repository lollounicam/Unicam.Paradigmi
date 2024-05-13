using Microsoft.AspNetCore.Mvc;
using Unicam.Paradigmi.Application.Abstractions;
using Unicam.Paradigmi.Application.Models.Responses;
using Unicam.Paradigmi.Application.Models.Requests;

namespace Unicam.Paradigmi.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UtenteController : ControllerBase
    {
        private readonly IUtenteService _utenteService;
        public UtenteController(IUtenteService utenteService)
        {
            _utenteService = utenteService;
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (_utenteService.Register(request.Nome, request.Cognome, request.Password, request.Email))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var token = _utenteService.Login(request.Email, request.Password);
            if (token != null)
            {
                return Ok(ResponseFactory.WithSuccess(new LoginResponse(token)));
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}