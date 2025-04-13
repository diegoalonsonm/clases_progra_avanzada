using Microsoft.Ajax.Utilities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Inventario.UI.Controllers
{
    public class AuthController : Controller
    {
        public JsonResult Login(string usuario, string contrasena)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("llave secreta"));

            var claims = new[]
            {
                new Claim(ClaimTypes.Role, "Administrador"),
            };

            var token = new JwtSecurityToken(
                issuer: "el issuer",
                audience: "el audience",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return Json(new {token = tokenString});
        }
    }
}
