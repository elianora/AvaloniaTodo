using AvaloniaTodo.DataModel;
using AvaloniaTodo.Services;
using ReactiveUI;
using System;
using System.Reactive.Linq;

namespace AvaloniaTodo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ToDoListViewModel ToDoList { get; }
    
    private ViewModelBase _contentViewModel;
    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public MainWindowViewModel(ToDoListService todoListService)
    {
        ToDoList = new ToDoListViewModel(todoListService.GetItems());
        _contentViewModel = ToDoList;
    }

    public void AddItem()
    {
        AddItemViewModel addItemViewModel = new();

        Observable.Merge(
            addItemViewModel.OkCommand,
            addItemViewModel.CancelCommand
                .Select(_ => (ToDoItem?)null))
                .Take(1)
                .Subscribe(newItem =>
                {
                    if (newItem is not null)
                    {
                        ToDoList.ListItems.Add(newItem);
                    }

                    ContentViewModel = ToDoList;
                });

        ContentViewModel = addItemViewModel;
    }
}
