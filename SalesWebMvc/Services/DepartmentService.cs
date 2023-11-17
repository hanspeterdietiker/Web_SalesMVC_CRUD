using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class DepartmentService
{
    private readonly SalesWebMvcContext _context;

    public DepartmentService(SalesWebMvcContext context)
    {
        _context = context;
    }

    public List<DepartmentModel> FindAll()
    {
        return _context.DepartmentModel.OrderBy(x => x.Name).ToList();
    }
}