namespace Entities;

public class TaxPayable (int id, string name)
{
	public int Id { get; set; } = id;
	public required string Name { get; set; } = name;
}