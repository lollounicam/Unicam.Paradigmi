﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Unicam.Paradigmi.Application.Abstractions;
using Unicam.Paradigmi.Application.Models.Requests;


namespace Unicam.Paradigmi.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddCategoria([FromBody] AddCategoriaRequest addCategoriaRequest)
        {
            if (_categoriaService.AddCategoria(addCategoriaRequest.nome))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("remove")]
        public IActionResult RemoveCategoria([FromBody] DeleteCategoriaRequest deleteCategoriaRequest)
        {
            if (_categoriaService.RemoveCategoria(deleteCategoriaRequest.nome))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
