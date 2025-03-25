﻿using FlashCardLearning.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FlashCardLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            if (loginDTO == null)
            {
                return BadRequest();
            }

            if (loginDTO.UserName == "nguyen" && loginDTO.Password == "def@1234")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ad2c1a2fa69728533ac3b18dd3489290"));

                // create a digital signature for token. 
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                // token attributes
                var tokenOptions = new JwtSecurityToken
                (
                    issuer: "https://localhost:7068",
                    audience: "https://localhost:7068",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                // create a token as a string
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new AuthenticatedResponseDTO { Token = tokenString });
            }

            return Unauthorized();
        }
    }
}
