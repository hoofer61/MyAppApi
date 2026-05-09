using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyAppApi.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// DB 연결 설정
// appsettings.json의 ConnectionStrings:DefaultConnection 읽어서 MSSQL 연결
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity 설정
// 회원가입, 로그인, 역할 관리 등 인증/권한 기능 등록
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // 인증 (누구냐?)
app.UseAuthorization();  // 권한 (뭘 할 수 있냐?)

app.MapControllers();

app.Run();