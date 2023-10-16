using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>(); // Especifica a classe Startup para configurar o aplicativo.
            });
}


/*
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {
    context.Response.Headers.Add("Content-Type", "text/html"); // cabeçalho header para html
    string content = File.ReadAllText("pages/Index.cshtml");
    
    return content;
});

app.Run();
*/