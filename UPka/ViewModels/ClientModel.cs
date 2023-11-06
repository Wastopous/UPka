using System.Reactive;
using ReactiveUI;
using UPka.Views;

namespace UPka.ViewModels;

public class ClientModel : ViewModelBase
{
    public string Search { get; set; }
    public string Sorting { get; set; }
    public ReactiveCommand<Unit, Unit> AddItem { get; set; }
    public ReactiveCommand<Unit, Unit> EditItem { get; set; }
    public ReactiveCommand<Unit, Unit> DeleteItem { get; set; }
    public ReactiveCommand<Unit, Unit> TableChoice { get; set; }
    

    public void AddItemMet()
    {
        
    }
    
    public void EditItemMet()
    {
        
    }
    
    public void DeleteItemMet()
    {
        
    }
    
    public void TableChoiceMet()
    {
        TablesWindow window = new TablesWindow();
        window.Show();
    }
    public ClientModel()
    {
        AddItem = ReactiveCommand.Create(AddItemMet);
        EditItem = ReactiveCommand.Create(EditItemMet);
        DeleteItem = ReactiveCommand.Create(DeleteItemMet);
        TableChoice = ReactiveCommand.Create(TableChoiceMet);
    }
}