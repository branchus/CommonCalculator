namespace Config;

public static class CusBuilder
{
    public static WebApplicationBuilder Create(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddOpenApiDocument(config =>
        {
            config.DocumentName = "Common Calculator API";
            config.Title = "Common Calculator API v1";
            config.Version = "v1";
        });
        return builder;
    }
}