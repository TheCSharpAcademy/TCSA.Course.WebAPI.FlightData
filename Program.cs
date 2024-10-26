var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); //swagger
builder.Services.AddSwaggerGen(); // swagger
builder.Services.AddControllers(); //added code 

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers(); //added code

app.Run();
