using System.Collections.Generic;
using System.Linq;

namespace Functions.SideEffects.After
{
	public class MasterPlan
	{
		private readonly IList<Activity> activities;

		public IReadOnlyList<Activity> Activities => activities.ToList();

		public MasterPlan(IEnumerable<Activity> activities)
		{
			this.activities = activities?.ToList();
		}

		public void AddActivity(Activity activity)
		{
			ValidateActivity(activity);

			activities.Add(activity);
		}

		private void ValidateActivity(Activity activity)
		{
			throw new System.NotImplementedException();
		}
	}
}