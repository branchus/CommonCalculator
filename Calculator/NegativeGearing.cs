using Entities;

namespace Calculator;

public partial class Calculation
{
	public IResult NegativeGearing(NegativeGearing ng)
	{
		return TypedResults.Created($"created {ng.Id}", ng);
	}
}