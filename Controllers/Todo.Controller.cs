using Microsoft.AspNetCore.Mvc;

/*
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
*/

[Route("todo")]
public class TodoController : Controller
{
    /*
    private readonly HttpClient _httpClient;

    public TodoController(IHttpClientFactory httpClientFactory){
        _httpClient = httpClientFactory.CreateClient();
    }
    */
    [HttpGet]
    public IActionResult Index()
    {   
        /*
        string url = "https://pokeapi.co/api/v2/pokemon/pikachu";

        try
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                // var pokemonData = await response.Content.ReadAsAsync<PokemonData>();
                return View("Home");
            }
            else
            {
                ViewBag.ErrorMessage = "O Pokémon Pikachu não foi encontrado.";
                return View();
            }
        }
        catch (HttpRequestException)
        {
            ViewBag.ErrorMessage = "Ocorreu um erro ao buscar os dados do Pokémon Pikachu.";
            return View();
        }
        */
        return RedirectToAction("Index", "Home"); // Redireciona para outro Index que esteja Fora da sua View
    }
}
