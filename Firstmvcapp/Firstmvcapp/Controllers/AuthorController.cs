using Firstmvcapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstmvcapp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            Dictionary<int,Author> list =AuthorRepository.GetAuthorDictionary();
            if(list != null&& list.Count>0)
            {
                return View("AuthorList", list.Values.ToList());
            }
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)  //
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            Author author = new Author();
            return View(author); //creating object and model binding
        }
        //2 edit, create and delete with and without parameter. 

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pauthor)
        {
            try
            {
                AuthorRepository.SaveToFile(pauthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id) //to update 
        {
            Author author= AuthorRepository.FindAuthorById(id);
            if(author!=null)
            {
                return View(author);
            }
           return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author pauthor)
        {
            try
            {
                AuthorRepository.UpdateAuthorToFile(pauthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if (author != null)
            {
                return View(author);
            }
            return View(author);
        }// POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                AuthorRepository.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      
    }
}
