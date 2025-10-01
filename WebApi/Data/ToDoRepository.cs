using ToDoApp.Models;

namespace ToDoApp.Data;

public class ToDoRepository
{
    private readonly List<ToDoItem> _todos = new();
    private int _nextId = 1;

    public IEnumerable<ToDoItem> GetAll() => _todos;

    public ToDoItem Add(ToDoItem item)
    {
        item.Id = _nextId++;
        _todos.Add(item);
        return item;
    }

    public bool Delete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null) return false;
        _todos.Remove(todo);
        return true;
    }
}
