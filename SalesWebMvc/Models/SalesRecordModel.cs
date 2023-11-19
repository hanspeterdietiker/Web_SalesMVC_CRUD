using System.ComponentModel.DataAnnotations;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models;

public class SalesRecordModel
{
    public int Id { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime Date { get; set; }

    [DisplayFormat(DataFormatString = "{0:F2}")]
    public double Amount { get; set; }

    public SaleStatusModel Status { get; set; }

    public SellerModel Seller { get; set; }

    public SalesRecordModel()
    {
    }

    public SalesRecordModel(int id, DateTime date, double amount, SaleStatusModel status, SellerModel seller)
    {
        Id = id;
        Date = date;
        Amount = amount;
        Status = status;
        Seller = seller;
    }
}