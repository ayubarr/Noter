using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Noter.Domain.Models.DTO.Common;
using Noter.Domain.Models.Entities;
using Noter.Services.Interfaces;

namespace Noter.MVC.Controllers
{
    public class NoteController : Controller
    {
        private readonly IAsyncBaseService<BaseDTO, Note> _services;
        public NoteController(IAsyncBaseService<BaseDTO, Note> services)
        {
            _services = services;
        }

        // GET: NoteController
        public ActionResult Get()
        {
            var response = _services.GetAll();
            return View(response.Data);
        }

        // GET: NoteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Get));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Get));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Get));
            }
            catch
            {
                return View();
            }
        }
    }
}
