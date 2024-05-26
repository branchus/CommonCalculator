namespace Config;

public static class CusApp
{
	public static void Create(WebApplicationBuilder wbBuilder)
	{
		var app = wbBuilder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseOpenApi();
            app.UseSwaggerUi(config =>
            {
                config.DocumentTitle = "Common Calculator API";
                config.Path = "/swagger";
                config.DocumentPath = "/swagger/{documentName}/swagger.json";
                config.DocExpansion = "list";
            });
        }

		Endpoints.Create(app);

		app.Run();
	}
}