using Microsoft.AspNetCore.Mvc;
using WorldCup.Models;
using WorldCup.Services;

namespace WorldCup.Controllers;

public class PaisController : Controller
{
    PaisService _service;

    public PaisController(PaisService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var paises = _service.GetAll();
        var count = _service.Count();
        ViewBag.PaisesCount = count;
        return View(paises);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Pais pais)
    {
        if (_service.Add(pais))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View(pais);
        }
    }

    public IActionResult Edit(int id)
    {
        var pais = _service.Get(id);
        return View(pais);
    }

    [HttpPost]
    public IActionResult Edit(int id, Pais paisToUpdate)
    {
        if (_service.Update(id, paisToUpdate))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View(paisToUpdate);
        }
    }


    public IActionResult Delete(int id)
    {
        var pais = _service.Get(id);
        return View(pais);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DoDelete(int id)
    {
        if (_service.Delete(id))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View(_service.Get(id));
        }
    }

    public IActionResult Count() {
        return new JsonResult(new {
            Count = _service.Count()
        });
    }
}