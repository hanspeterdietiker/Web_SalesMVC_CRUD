using Microsoft.OpenApi.Models;

namespace SalesWebMvc.Extensions;

public static class SwaggerSetup
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        return services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "OpenApi Doc- SalesWeb ",
                Version = "v1",
                Description = "First Project with ASP .NET CORE",
                Contact = new OpenApiContact()
                {
                    Name = "Hanspeter Dietiker",
                    Email = "contactdevhanspeter@gmail.com",
                   
                }
            });
            string xmlPath = Path.Combine("wwwroot", "api-doc.xml");
            opt.IncludeXmlComments(xmlPath);
        });
    }

    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
    {
        return app.UseSwagger().UseSwaggerUI(c =>
        {
            c.RoutePrefix = "documentation";
            c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
        });

    }
}