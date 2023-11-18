using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Execptions;

namespace SalesWebMvc.Services;

public class SellerService
{
    private readonly SalesWebMvcContext _context;

    public SellerService(SalesWebMvcContext context)
    {
        _context = context;
    }

    public List<SellerModel> FindAll()
    {
        return _context.Seller.ToList();
    }

    public void Insert(SellerModel seller)
    {
        _context.Add(seller);
        _context.SaveChanges();
    }

    public SellerModel FindById(int id)
    {
        return _context.Seller
            .Include(obj => obj.Department)
            .FirstOrDefault(obj => obj.Id == id);
    }

    public void Remove(int id)
    {
        var obj = _context.Seller.Find(id);
        _context.Seller.Remove(obj);
        _context.SaveChanges();
    }

    public void Update(SellerModel obj)
    {
        if (!_context.Seller.Any(x => x.Id == obj.Id))
        {
            throw new NotFoundException("Id não encontrada");
        }

        try
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        catch (DbConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
        
            
        
    }
}