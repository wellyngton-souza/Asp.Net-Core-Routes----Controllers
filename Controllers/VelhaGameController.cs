using Microsoft.AspNetCore.Mvc;

[Route("velha")]
public class VelhaGameController : Controller{
    [HttpGet]
    public IActionResult Index(){
        return View();
    }
}