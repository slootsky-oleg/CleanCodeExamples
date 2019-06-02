using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.Core;

namespace Functions.Test.Answers.API.Models.MasterPlans.Participants
{
	public class FixedParticipantBuilder
	{
		private readonly DateRangeDto fixedRange;

		public FixedParticipantBuilder(MasterPlan masterPlan)
		{
			fixedRange = new DateRangeDto(masterPlan.FixedDates);
		}

		public FixedParticipantDto Build(Participant participant)
		{
			return new FixedParticipantDto(participant, fixedRange);
		}
	}
}