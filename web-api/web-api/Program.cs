using Dal;
using Bll;
using Bll.Interfaces;
using Dal.interfaces;
using Entity;
using AutoMapper;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserBll, UserBll>();
builder.Services.AddScoped<IUserDal, UserDal>();
builder.Services.AddScoped<ICoronaDetailsBll, CoronaDtailseBll>();
builder.Services.AddScoped<ICoronaDetailsDal, CoronaDetailsDal>();
builder.Services.AddScoped<ICoronaVaccineBll, CoronaVaccineBll>();
builder.Services.AddScoped<ICoronaVaccineDal, CoronaVaccineDal>();

builder.Services.AddDbContext<ProjectContext>();

var mapp = new MapperConfiguration(x =>
{
    x.AddProfile(new MapperProfile());
});

IMapper mapper=mapp.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
