using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

namespace WebKhoaHoc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungsController : ControllerBase
    {
        private readonly IRepository<NguoiDung> _repository;
        private readonly IMapper _mapper;
        private readonly WebKhoaHocDbContext _context;
        private readonly AppSettings _appSettings;

        public NguoiDungsController(IRepository<NguoiDung> repository, IMapper mapper, WebKhoaHocDbContext context, IOptionsMonitor<AppSettings> optionsMonitor)
        {
            _repository = repository;
            _mapper = mapper;
            _context = context;
            _appSettings = optionsMonitor.CurrentValue;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NguoiDung>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<NDModel>(entity);
            return Ok(rm);
        }


        [HttpPost]
        public async Task<ActionResult<NDModel>> Add(NDModel model)
        {
            var entity = _mapper.Map<NguoiDung>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<NDModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaND }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, NDModel model)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            _mapper.Map(model, entity);
            await _repository.UpdateAsync(entity);
            var resultModel = _mapper.Map<NDModel>(entity);
            return Ok(resultModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }


        [HttpPost("Login")]
        public IActionResult Validate(LoginModel model)
        {
            //var password = Password.hashPassword(model.Password);
            var user = _context.NguoiDung.SingleOrDefault(p => p.TenDangNhap == model.TenDangNhap && p.Password == model.Password);
            if (user == null) //không đúng
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid username/password"
                });
            }

            //cấp token

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Authenticate success",
                Token = GenerateToken(user)
            });
        }


        private string GenerateToken(NguoiDung nguoiDung)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var secretKeyBytes = Encoding.UTF8.GetBytes(_appSettings.SecretKey);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, nguoiDung.TenND),
                    new Claim(ClaimTypes.Email, nguoiDung.email),
                    new Claim("UserName", nguoiDung.TenDangNhap),
                    new Claim("Id", nguoiDung.MaND.ToString()),

                    //roles

                    new Claim("TokenId", Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescription);

            return jwtTokenHandler.WriteToken(token);
        }
    }
}
