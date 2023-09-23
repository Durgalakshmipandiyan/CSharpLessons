using Firstmvcapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstmvcapp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController

        public ActionResult Index()
        {
            List <Emptable> empList=EmpdbRepository.GetEmpList();
            return View(empList);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            Emptable emp=EmpdbRepository.GetEmpbyId(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Emptable emp=new Emptable();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Emptable pEmp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpdbRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            {

                if (id <= 0)
                {
                    return RedirectToAction("Index");
                }
                Emptable emp = EmpdbRepository.GetEmpbyId(id);
                return View(emp);
            }
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Emptable pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpdbRepository.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emptable emp = EmpdbRepository.GetEmpbyId(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                EmpdbRepository.DeleteEmp(id);
            }
            return RedirectToAction(nameof(Index));
        }
        }
    }
