using System.Collections;

namespace General.Casting
{
	public class SizeCalculator
	{
		public int SizeOf(IEnumerable items)
		{
			if (items is ICollection collection)
			{
				return collection.Count;
			}

			int size = 0;
			foreach (var item in items)
			{
				++size;
			}

			return size;
		}
	}
}