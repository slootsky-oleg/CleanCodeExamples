using System.Collections.Generic;
using System.Linq;
using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.API.Models.MasterPlans.Participants;
using Functions.Test.Answers.Core.After;

namespace Functions.Test.Answers.API.Models.MasterPlans
{
	public class MasterPlanDto
	{
		public long Id { get; }
		public string Name { get; }
		public DateRangeDto FixedDates { get; }
		public IReadOnlyList<ParticipantDto> Participants { get; }

		public MasterPlanDto(MasterPlan source)
		{
			Id = source.Id;
			Name = source.Name;
			FixedDates = new DateRangeDto(source.FixedDates);
			Participants = source
				.Participants
				.Select(x => new ParticipantDto(x))
				.ToList();
		}
	}
}