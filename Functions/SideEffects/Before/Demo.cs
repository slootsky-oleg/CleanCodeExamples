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


			//Real world: Get from DB
			var masterPlan = new MasterPlan {Activities = activities};

			//Analyze(masterPlan);
			//SendToExternalService(masterPlan);
			//var ids = GetActivityIds(masterPlan);

			var logger = new Logger();
			logger.Log(masterPlan.Activities);

			//SaveToDataBase(activities);

			//Select From Activities: Two activities lost, 1 name changed
		}
	}
}
