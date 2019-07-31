using System.Collections;

namespace General.Casting.AfterOverloading
{
	public class SizeCalculator
	{
public int SizeOf(ICollection items)
{
	return items.Count;
}

public int SizeOf(IEnumerable items)
{
	int size = 0;

	foreach (var item in items)
	{
		++size;
	}

	return size;
}
	}
}