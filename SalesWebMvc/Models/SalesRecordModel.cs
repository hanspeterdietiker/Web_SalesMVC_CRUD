using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models;

public class SalesRecordModel
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public SaleStatusModel StatusModel { get; set; }

    public SellerModel Seller { get; set; }

    public SalesRecordModel()
    {
        
    }
    public SalesRecordModel(int id, DateTime date, double amount, SaleStatusModel statusModel)
    {
        Id = id;
        Date = date;
        Amount = amount;
        StatusModel = statusModel;
    }
}