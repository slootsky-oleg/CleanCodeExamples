using System.Collections.Generic;
using System.Linq;

namespace Functions.SideEffects.After
{
	public class MasterPlan
	{
		public IReadOnlyList<Activity> Activities { get; }

		public MasterPlan(IEnumerable<Activity> activities)
		{
			Activities = activities?.ToList();
		}
	}
}