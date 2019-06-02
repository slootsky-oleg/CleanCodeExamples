using System;
using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.Core;

namespace Functions.Test.Answers.API.Models.MasterPlans.Participants
{
	public class FixedParticipantDto
	{
		public int Id { get; }
		public string Name { get; }
		public DateRangeDto AssignmentDates { get; }

		public FixedParticipantDto(Participant source, DateRangeDto fixedAssignmentDates)
		{
			Id = source.Id;
			Name = source.Name;
			AssignmentDates = fixedAssignmentDates
			                  ?? throw new ArgumentNullException(nameof(fixedAssignmentDates));
		}
	}
}