using BlipChallenge.Models.Settings;
using BlipChallenge.Services.External;
using BlipChallenge.Services.External.Clients;
using RestEase;

var builder = WebApplication.CreateBuilder(args);

var appSettings = builder.Configuration.GetSection("ApplicationSettings").Get<AppSettings>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGitHubServices, GitHubServices>();
builder.Services.AddSingleton(RestClient.For<IGitHubClient>(appSettings.GitHubApi.Url));

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
