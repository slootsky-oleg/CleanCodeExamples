using System.Collections.Generic;

namespace Functions.SideEffects.Before
{
	class Demo
	{
		public void RunDemo()
		{
			var activities = new List<Activity>
			{
				new Activity {Id = 1, Name = "A"},
				new Activity {Id = 2, Name = "B"},
				new Activity {Id = 3, Name = "C"},
			};

			var masterPlan = new MasterPlan {Activities = activities};

			//Analyze(masterPlan);
			//SendToExternalService(masterPlan);
			//var ids = GetIds(masterPlan);

			var logger = new Logger();
			logger.Log(masterPlan.Activities);

			//SaveToDataBase(activities);
		}
	}
}
