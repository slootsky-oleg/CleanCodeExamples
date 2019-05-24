using System.Collections.Generic;

namespace Functions.SideEffects.After
{
	class Demo
	{
		public void RunDemo()
		{
			var activities = new List<Activity>
			{
				new Activity(1, "A"),
				new Activity(2, "B"),
				new Activity(3, "C"),
			};

			var masterPlan = new MasterPlan(activities);

			//Analyze(masterPlan);
			//SendToExternalService(masterPlan);
			//var ids = GetActivityIds(masterPlan);

			var logger = new Logger();
			logger.Log(masterPlan.Activities);

			//SaveToDataBase(masterPlan);
		}
	}
}
