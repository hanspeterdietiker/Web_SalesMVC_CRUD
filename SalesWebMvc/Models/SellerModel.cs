using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models;

public class SellerModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe seu {0}")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Nome deve haver mais caracteres")]
    public string Name { get; set; }

   
    [EmailAddress(ErrorMessage = "Informe um {0} valido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe seu {0}")]
    [DataType(DataType.Date)]
    [Display(Name = "Birth Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Informe seu {0}")]
    [DisplayFormat(DataFormatString = "{0:F2}")]
    [Display(Name = "Base Salary")]
    public double BaseSalary { get; set; }

    public DepartmentModel Department { get; set; }

    [Display(Name = "Department Id")] public int DepartmentId { get; set; }

    public ICollection<SalesRecordModel> Sales { get; set; } = new List<SalesRecordModel>();

    public SellerModel()
    {
    }

    public SellerModel(int id, string name, string email, DateTime birthDate, double baseSalary,
        DepartmentModel department)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        Department = department;
    }

    public void AddSales(SalesRecordModel sr)
    {
        Sales.Add(sr);
    }

    public void RemoveSales(SalesRecordModel sr)
    {
        Sales.Remove(sr);
    }

    public double TotalSales(DateTime initial, DateTime final)
    {
        return Sales
            .Where(sr => sr.Date >= initial && sr.Date <= final)
            .Sum(sr => sr.Amount);
    }
}