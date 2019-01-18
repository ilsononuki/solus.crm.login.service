using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using solus.crm.login.service.Domain.Domain;
using solus.crm.login.service.Domain.Interfaces;

namespace solus.crm.login.service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpGet("{Email}/{Password}")]
        public AuthModel GetAuth(string Email, string Password)
        {
            var model = _authRepository.GetAuth(Email, Password);
            return model;
        }


        [HttpPost("Register")]
        public IActionResult RegisterAuth([FromBody] AuthModel model)
        {
            if (!_authRepository.ExistAccount(model.Email))
            {
                model.Id = Guid.NewGuid();
                model.Created = DateTime.Now;

                _authRepository.Register(model);
                return Ok("Cadastrado com Sucesso.");
            }
            else
            {
                return BadRequest("Email já cadastrado.");
            }
        }

        // PUT: api/Auth/5
        [HttpPatch("Update/{id}")]
        public void Update(Guid id, [FromBody] AuthModel model)
        {
            _authRepository.Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
