using Microsoft.EntityFrameworkCore;
using studentInfoHub.Data;
using studentInfoHub.Services.StudentServ;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DatabaseConnection"))
    );
builder.Services.AddControllers();

builder.Services.AddCors(option =>{
    option.AddPolicy("CorsPolicy",
        builder => {
        builder.AllowAnyHeader() // Allows any additional info sent with request (cookies)
        .AllowAnyMethod() // Allows any Httop Methods (HttpGet, HttpPut, etc)
        .AllowAnyOrigin(); // Allows any domain to access your API
        }
    );
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
