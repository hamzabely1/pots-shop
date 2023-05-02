using Api.Ioc;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureDBContext(configuration);
builder.Services.ConfigureInjectionDependencyRepository();
builder.Services.ConfigureInjectionDependencyService();
builder.Services.AddCors(
    options => options.AddPolicy("TestPolicy",
        policy => policy.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
    ) 
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("TestPolicy");
app.MapControllers();

app.Run();
