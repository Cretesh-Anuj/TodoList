using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using Task = TodoList.Models.Task;


namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TaskContext _taskContext;

        public HomeController(ILogger<HomeController> logger, TaskContext taskContext)
        {
            _logger = logger;
            _taskContext = taskContext;
        }

        public IActionResult Index()
        {
            List<Task> tasks = _taskContext.Tasks.ToList();
            return View(tasks);
        }
        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            _taskContext.Add(task);
            _taskContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
