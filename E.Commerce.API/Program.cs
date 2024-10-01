using E.Commerce.Application.Contract;
using E.Commerce.Application.Services;
using E.Commerce.Identity;
using E.Commerce.Infrastracture;
using E.Commerce.Infrastracture.ContextDemo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle 
builder.Services.AddEndpointsApiExplorer();
    
builder.Services.AddDbContextPool<DemoContext>(ops => ops.UseSqlServer(
    new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("mycon")));


builder.Services.AddDbContextPool<AppIdentityContext>(ops => ops.UseSqlServer(
    new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("mycon")));

var key = Encoding.ASCII.GetBytes("JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "http://localhost:5100",
        ValidAudience = "http://localhost:5100",
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

    
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
     {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header
                },
                new List<string>()
            }
     });
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 3;
        options.Password.RequireNonAlphanumeric = false;

    })
               .AddEntityFrameworkStores<AppIdentityContext>().AddDefaultTokenProviders();

builder.Services.AddTransient(typeof(IAsyncRepository<>), typeof(AsyncRepsitory<>));
builder.Services.AddScoped<IProductAppServices, ProductAppService>();
builder.Services.AddScoped<IOrderAppServices, OrderedAppSerivce>();
builder.Services.AddScoped<IUserRoleAppServices, AccountAppServices>();
builder.Services.AddScoped<ICartAppServices, CartAppService>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICategoryAppServices, CategoryAppServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
