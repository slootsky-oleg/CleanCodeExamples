using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions.SideEffects.Before
{
	public class Logger
	{
		public void Log(List<Activity> activities)
		{
			foreach (var activity in activities)
			{
				Console.WriteLine($"Activity Id: {activity.Id}, Name: {activity.Name}");

				if (activity.Name == "A")
				{
					activity.Name = "Not A";
				}
			}

			activities.RemoveAll(x => x.Id > 1);
		}
	}
}