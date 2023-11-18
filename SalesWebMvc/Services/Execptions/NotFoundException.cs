namespace SalesWebMvc.Services.Execptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string message) : base(message)
    {
        
    }
}