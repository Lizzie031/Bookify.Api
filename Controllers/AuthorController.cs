using BankApp.Api.Dtos.Requests;
using BankApp.Api.Model;
using BankApp.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Api.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

/*
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAuthor([FromBody] AddAuthorRequest request)
            await _authorService.AddAuthor(request);
            return StatusCode(201);
        }*/

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor([FromBody] Author request)
        {
            var response = await _authorService.UpdateAuthor(request);
            return Ok(response);
        }

        [HttpGet("GetAllAuthor")]
        public async Task<IActionResult> GetAllAuthor()
        {
            var response = await _authorService.GetAllAuthor();
            return Ok(response);
        }

        [HttpGet("GetAuthorById/{id}")]
        public async Task<IActionResult> GetAuthorById([FromRoute] int id)
        {
            var response = await _authorService.GetAuthorById(id);
            return Ok(response);
        }
    }
}


