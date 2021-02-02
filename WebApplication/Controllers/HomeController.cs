using System;
using System.Diagnostics;
using Businnes.Abstract;
using Core.Aspect.Autofac.Logging;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITesisServices _tesisServices;

        public HomeController(ILogger<HomeController> logger, ITesisServices tesisServices)
        {
            _logger = logger;
            _tesisServices = tesisServices;
        }

        [LogAspect]
        public IActionResult Index()
        {
            var result = _tesisServices.GetAllList();
            return View(result);
        }

        [LogAspect]
        public IActionResult Ekle()
        {
            return View();
        }

        [LogAspect]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(Tesis tesis)
        {
            if (ModelState.IsValid)
            {
                _tesisServices.Add(tesis);
                TempData["Mesaj"] = "Ürün başarılı şekilde eklendi...";
                TempData["Uyari"] = "success";
                return RedirectToAction(nameof(Index));
            }

            return View(tesis);
        }

        public IActionResult Edit(int id)
        {
            var urun = _tesisServices.GetTesis(id);
            if (urun == null) return NotFound();
            return View(urun);
        }

        // POST: UrunIslemleri/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Adres")] Tesis tesis)
        {
            if (id != tesis.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _tesisServices.Update(tesis);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                TempData["Mesaj"] = "Ürün başarılı şekilde güncellendi...";
                TempData["Uyari"] = "secondary";
                return RedirectToAction(nameof(Index));
            }

            return View(tesis);
        }

        public IActionResult Delete(int id)
        {
            var urun = _tesisServices.Get(id);
            if (urun == null) return NotFound();

            return View(urun);
        }

        // POST: UrunIslemleri/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            TempData["Mesaj"] = "Ürün başarılı şekilde silindi...";
            TempData["Uyari"] = "danger";
            return RedirectToAction(nameof(Index));
        }

        [LogAspect]
        public IActionResult Details(int id)
        {
            var entity = _tesisServices.Get(id);
            if (entity == null) return NotFound();
            return View(entity);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}