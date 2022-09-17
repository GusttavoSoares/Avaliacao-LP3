using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLP3.ViewModels;

namespace Avaliacao3BimLP3.Controllers;

public class LojaController : Controller
{
  
    private static List<LojaViewModel> lojas =
    new List<LojaViewModel> {
        new LojaViewModel(1, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", true, "tenis@email.com"),
        new LojaViewModel(2, "piso 3", "Lembranças Já", "Vem comprar sua lembrança", true, "lemb@email.com"),
        new LojaViewModel(3, "piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", false, "sorvet@email.com"),
    };
        
    public IActionResult Index()
    {
        return View(lojas);
    }

    public IActionResult AdminIndex()
    {
        return View(lojas);
    }

    public IActionResult AdminShow(int id)
    {
        return View(lojas[ id-1 ]);
    }

    public IActionResult AdminDelete(int id)
    {
        lojas.RemoveAt(id - 1);
        return View("AdminIndex");
    }

    public IActionResult AdminCreate()
    {
        return View();
    }

     public IActionResult AdminResult([FromForm] LojaViewModel loja)
    {
        LojaViewModel lojaCreate = new LojaViewModel(loja.Id, loja.Piso, loja.Nome, loja.Descricao, loja.IsLoja, loja.Email);
        lojas.Add(lojaCreate);
        return View();
    }
}
