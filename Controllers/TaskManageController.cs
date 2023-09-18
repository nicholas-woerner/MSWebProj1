using Microsoft.AspNetCore.Mvc;
using MSwebPROJ1.Models;

namespace MSwebPROJ1.Controllers
{
    public class TaskManageController : Controller
    {

        private List<TaskModel> tasks = new();
        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                //Add new task to the list
                //(This would generally be saved to a database)
                tasks.Add(task);

                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}
