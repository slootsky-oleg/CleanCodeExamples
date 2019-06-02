using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.Core.DifferentPropertySets;

namespace Functions.Test.Answers.API.Models.MasterPlans.Different
{
	public class MasterPlanPopUpDto
	{
		public long Id { get; }
		public string Name { get; }
		public DateRangeDto FixedDates { get; }

		public MasterPlanPopUpDto(MasterPlanHeader source)
		{
			Id = source.Id;
			Name = source.Name;
			FixedDates = new DateRangeDto(source.FixedDates);
		}
	}
}