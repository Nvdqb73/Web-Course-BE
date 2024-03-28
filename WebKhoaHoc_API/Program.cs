using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("MyCorsCourse", build =>
{
    //build.WithOrigins("https://khoahoc.info", "https://localhost:7224", "http://localhost:3003/");
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));


#region Khai báo Database

builder.Services.AddDbContext<WebKhoaHocDbContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("WebKhoaHoc"));
});

#endregion

#region Khai báo Repository

builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BaiHoc>, Repository<BaiHoc>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BaiTap>, Repository<BaiTap>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BinhLuan>, Repository<BinhLuan>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<Chat>, Repository<Chat>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<ChungChi>, Repository<ChungChi>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<DonHang>, Repository<DonHang>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<GiangVien>, Repository<GiangVien>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<LoaiKH>, Repository<LoaiKH>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<NguoiDung>, Repository<NguoiDung>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<PhanHoi>, Repository<PhanHoi>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<LoaiTT>, Repository<LoaiTT>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<KhoaHoc>, Repository<KhoaHoc>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<Role>, Repository<Role>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<QuanTriVien>, Repository<QuanTriVien>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.ISearchKH, SearchRepo>();

#endregion





builder.Services.AddAutoMapper(typeof(Program));


var secretKey = builder.Configuration["AppSettings:SecretKey"];
var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            //tự cấp token
            ValidateIssuer = false,
            ValidateAudience = false,
            //ký vào token
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),
            ClockSkew = TimeSpan.Zero
        };
    });


WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyCorsCourse");

app.UseAuthorization();

app.MapControllers();

app.Run();
