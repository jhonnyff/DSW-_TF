
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(opciones => opciones.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true).AddJsonOptions(opciones =>
{
    //opciones.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
PLANILLA.CONEXION.Base.ConnectionString = builder.Configuration.GetConnectionString("Conexion");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
