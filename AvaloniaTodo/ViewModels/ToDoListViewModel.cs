using AvaloniaTodo.DataModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaTodo.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }

    public ObservableCollection<ToDoItem> ListItems { get; }
}
