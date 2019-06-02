using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.Core;

namespace Functions.Test.Answers.API.Models.MasterPlans.Participants
{
	public class ParticipantDto
	{
		public long Id { get; }
		public string Name { get; }
		public DateRangeDto AssignmentDates { get; }

		public ParticipantDto(Participant source)
		{
			Id = source.Id;
			Name = source.Name;
			AssignmentDates = new DateRangeDto(source.AssignmentDates);
		}
	}
}