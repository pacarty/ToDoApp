using Microsoft.AspNetCore.Mvc;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToDoController : ControllerBase
{
    private readonly ToDoRepository _repo;

    public ToDoController(ToDoRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ToDoItem>> GetAll() => Ok(_repo.GetAll());

    [HttpPost]
    public ActionResult<ToDoItem> Add(ToDoItem item) => Ok(_repo.Add(item));

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return _repo.Delete(id) ? NoContent() : NotFound();
    }
}
