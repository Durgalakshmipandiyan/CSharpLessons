using Firstmvcapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstmvcapp.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<MovieDemo> movieList = MovieRepository.GetMovieList();
            return View(movieList);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            MovieDemo movie = MovieRepository.GetMoviebyId(id);
            return View(movie);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            MovieDemo movie = new MovieDemo();
            return View(movie);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,MovieDemo pmovie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieRepository.AddNewMovie(pmovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            {

                if (id <= 0)
                {
                    return RedirectToAction("Index");
                }
                MovieDemo movie = MovieRepository.GetMoviebyId(id);
                return View(movie);
            }
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,MovieDemo pmovie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieRepository.UpdateMovie(pmovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            MovieDemo movie = MovieRepository.GetMoviebyId(id);
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.DeleteMovie(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

