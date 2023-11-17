using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class SellerService
{
    private readonly SalesWebMvcContext _context;

    public SellerService(SalesWebMvcContext context)
    {
        _context = context;
    }
    
    public  List<SellerModel> FindAll()
    {
        return _context.Seller.ToList();
    }

    public void Insert(SellerModel seller)
    {
        _context.Add(seller);
        _context.SaveChanges();
    }
}