using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ApplicationDBContext _context;
    private readonly PasswordService _passwordService;

    public UserController(IConfiguration configuration,ApplicationDBContext context, PasswordService passwordService)
    {
        _configuration  = configuration;
        _context = context;
        _passwordService = passwordService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        if (await _context.Users.AnyAsync(u=> u.email == request.email))
            return BadRequest("mail already in use.");

        //Generar el nombre del usuario a partir del corrreo 
        var username = request.email.Split('@')[0];

        var user = new User
        {
            username = username,
            email = request.email,
            password = _passwordService.HashPassword(request.password)
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok(new {message = "User registered successfully"});
    }

[HttpPost("login")]
public async Task<IActionResult> Login([FromBody] LoginRequest request)
{
    var user = await _context.Users.SingleOrDefaultAsync(u => u.email == request.email);
    if (user == null || !_passwordService.VerifyPassword(request.password, user.password))
        return Unauthorized("Invalid email or password.");

    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]);
    var tokenDescriptor = new SecurityTokenDescriptor
    {
        Subject = new ClaimsIdentity(new[] {
            new Claim(ClaimTypes.Name, user.user_id.ToString()),
            new Claim(ClaimTypes.Email, user.email)
        }),
        Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["JwtSettings:ExpirationMinutes"])),
        Issuer = _configuration["JwtSettings:Issuer"],
        Audience = _configuration["JwtSettings:Audience"],
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
    };

    var token = tokenHandler.CreateToken(tokenDescriptor);
    var tokenString = tokenHandler.WriteToken(token);

    return Ok(new { Token = tokenString });
}

}
