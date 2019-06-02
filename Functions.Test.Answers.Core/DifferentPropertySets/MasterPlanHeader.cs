using System;

namespace Functions.Test.Answers.Core.DifferentPropertySets
{
	public class MasterPlanHeader
	{
		public long Id { get; }
		public string Name { get; }
		public DateRange FixedDates { get; }

		public MasterPlanHeader(long id, string name, DateRange fixedDates)
		{
			Id = id;
			Name = name;
			FixedDates = fixedDates ?? throw new ArgumentNullException(nameof(fixedDates));
		}
	}
}