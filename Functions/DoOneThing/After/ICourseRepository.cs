using System.Collections.Generic;

namespace Functions.DoOneThing.After
{
	public interface ICourseRepository
	{
		IEnumerable<Course> GetByOwner(int ownerId);
	}
}