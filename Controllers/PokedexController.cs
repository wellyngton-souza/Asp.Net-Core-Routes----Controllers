using Microsoft.AspNetCore.Mvc;

[Route("pokedex")]
public class PokedexController : Controller{
    [HttpGet]
    public IActionResult Index(){
        return View();
    }
}