namespace SalesWebMvc.Services.Execptions;

public class IntegrityException : ApplicationException
{
    public IntegrityException(string message) : base(message)
    {
        
    }
}