using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("todo")]
public class TodoController : Controller
{
     private readonly IHttpClientFactory _clientFactory;

    public TodoController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        // Criar um cliente HTTP usando a factory
        var client = _clientFactory.CreateClient();

        // Fazer uma solicitação GET à API do Pokémon
        var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/1");

        if (response.IsSuccessStatusCode)
        {
            // Ler e desserializar o conteúdo JSON retornado
            var pokemon = await response.Content.ReadFromJsonAsync<Pokemon>();

            // Você pode criar uma classe Pokemon para desserializar os dados
            // Exemplo de classe Pokemon:
            // public class Pokemon
            // {
            //     public string Name { get; set; }
            //     public int Height { get; set; }
            //     public int Weight { get; set; }
            //     // Outras propriedades do Pokémon
            // }

            return View(pokemon);
        }
        else
        {
            return View();
        //return RedirectToAction("Index", "Home"); // Redireciona para outro Index que esteja Fora da sua View
        }
    }
}
