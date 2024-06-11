using Entities;

namespace Calculator;

public partial class Calculation
{
	public IResult TaxPayable(string taxYear, int income)
	{
		return TypedResults.Created($"created {income}", taxYear);
	}
}