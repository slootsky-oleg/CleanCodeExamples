using System;
using General.FeatureEnvy.Common;

namespace General.FeatureEnvy.Before
{
	public class HourlyEmployee
	{
		public Salary Salary { get; set; }

		public WorkingReport GetWorkingReport(Week week)
		{
			throw new NotImplementedException();
		}
	}
}