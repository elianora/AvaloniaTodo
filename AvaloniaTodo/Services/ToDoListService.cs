using AvaloniaTodo.DataModel;
using System.Collections.Generic;

namespace AvaloniaTodo.Services;

public class ToDoListService
{
    public IEnumerable<ToDoItem> GetItems() =>
        [
            new ToDoItem() { Description = "Walk the dog" },
            new ToDoItem() { Description = "Buy some milk" },
            new ToDoItem() { Description = "Learn Avalonia", IsChecked = true }
        ];
}
