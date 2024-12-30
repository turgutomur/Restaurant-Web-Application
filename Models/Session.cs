using RestaurantManagementApp.Models;

public class Session
{
    public int Id { get; set; }
    public string? CustomerName { get; set; }
    public int TableNumber { get; set; }
    public List<MenuItem> Items { get; set; } = new();
    public List<int> SelectedItemIds { get; set; } = new();

    public decimal TotalPrice => Items.Sum(item => item.Price); // Calculated total price from selected items
}
