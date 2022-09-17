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
        foreach (var loja in lojas)
        {
            if (loja.Id == id)
            {
                return View(loja);
            }
        }
        return View(); // nunca vai cair aqui se passar um Id válido, entretanto poderia retornar uma mensagem para valores válidos

    }

    public IActionResult AdminDelete(int id)
    {
        for(int i =0 ; i< lojas.Count(); i++)
        {
            if (lojas[i].Id == id)
            {
                lojas.RemoveAt(i);
            } 
        }
        return View("AdminDeleteResult");
    }

    public IActionResult AdminCreate()
    {
        return View();
    }

    public IActionResult AdminResult([FromForm] LojaViewModel lojaCreate)
    {
        foreach (var loja in lojas)
        {
            if (loja.Nome == lojaCreate.Nome)
            {
                return View("CreateError");
            }
        }
        // LojaViewModel lojaCreate = new LojaViewModel(lojaCreate.Id, lojaCreate.Piso, lojaCreate.Nome, lojaCreate.Descricao, lojaCreate.IsLoja, lojaCreate.Email);
        lojas.Add(lojaCreate);
        return View();
    }
}
