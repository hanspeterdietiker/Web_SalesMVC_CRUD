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

    public async Task<List<SellerModel>> FindAllAsync()
    {
        return  await _context.Seller.ToListAsync();
    }

    public  async Task InsertAsync(SellerModel seller)
    {
        _context.Add(seller);
       await _context.SaveChangesAsync();
    }

    public async Task<SellerModel> FindByIdAsync(int id)
    {
        return  await _context.Seller
            .Include(obj => obj.Department)
            .FirstOrDefaultAsync(obj => obj.Id == id);
    }

    public async Task RemoveAsync(int id)
    {
        var obj = await _context.Seller.FindAsync(id);
        _context.Seller.Remove(obj);
       await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SellerModel obj)
    {
        bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
        if (!hasAny)
        {
            throw new NotFoundException("Id não encontrada");
        }

        try
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
        }
        catch (DbConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
        
            
        
    }
}