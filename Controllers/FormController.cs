using Microsoft.AspNetCore.Mvc;

public class MeuModel
{
    public int Nome1 { get; set; }
    public int Nome2 { get; set; }
}

[Route("form")]
public class FormController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ProcessForm(int nome1, int nome2)
    {
        MeuModel meuModel = new MeuModel{
            Nome1 = nome1,
            Nome2 = nome2
        };

        return View("ProcessForm", meuModel);
    }
}
