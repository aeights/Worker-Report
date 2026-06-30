using Worker_Report;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.Sources.Clear();
builder.Configuration.AddYamlFile("appsettings.yaml", optional: false, reloadOnChange: true);

var env = builder.Environment.EnvironmentName;
builder.Configuration.AddYamlFile($"appsettings.{env}.yaml", optional: true, reloadOnChange: true);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddApplicationServices(
    builder.Configuration,
    builder.Environment);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseExceptionHandler();
app.MapControllers();
app.Run();