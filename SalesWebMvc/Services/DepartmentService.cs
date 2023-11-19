using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class DepartmentService
{
    private readonly SalesWebMvcContext _context;

    public DepartmentService(SalesWebMvcContext context)
    {
        _context = context;
    }

    public async Task<List<DepartmentModel>> FindAllAsync()
    {
        return await _context.DepartmentModel.OrderBy(x => x.Name).ToListAsync();
    }
}