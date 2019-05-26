using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions.SideEffects.Before;

namespace Functions
{
	class Program
	{
		static void Main(string[] args)
		{
			var logger = new Logger();

			var activities = new List<Activity>
			{
				new Activity {Id = 1, Name = "A"},
				new Activity {Id = 2, Name = "B"},
				new Activity {Id = 3, Name = "C"},
			};

			logger.Log(activities);
		}
	}
}
