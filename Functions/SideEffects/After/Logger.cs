using System;
using System.Collections.Generic;

namespace Functions.SideEffects.After
{
	public class Logger
	{
		public void Log(IEnumerable<Activity> activities)
		{
			foreach (var activity in activities)
			{
				Console.WriteLine($"Activity Id: {activity.Id}, Name: {activity.Name}");

				//if (activity.Name == "A")
				//{
				//	activity.Name = "Not A";
				//}
			}

			//activities.RemoveAll(x => x.Id > 1);
		}
	}
}