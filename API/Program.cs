using API.Data;
using Microsoft.EntityFrameworkCore;

    
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddDbContext<DataContext>(Opt => 
        {
            Opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        builder.Services.AddCors();
        var app = builder.Build();
    
      //     Configure the HTTP request pipeline.
      app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://Localhost:4200"));

    


app.UseHttpsRedirection();
        app.UseAuthorization();

         app.MapControllers();

         app.Run();
   
   
