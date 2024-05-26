using Calculator;

namespace Config;

public static class Endpoints
{
	public static void Create(WebApplication wba)
	{
		wba.MapGet("/", () => "Hello World!");
		wba.MapPost("/NegativeGearing", new Calculation().NegativeGearing);
	}
}