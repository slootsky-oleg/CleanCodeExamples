using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions.Test.Answers.Core
{
	public class MasterPlan
	{
		private readonly IList<Participant> participants;

		public long Id { get; }
		public string Name { get; }
		public DateRange FixedDates { get; }

		public IReadOnlyList<Participant> Participants => participants.ToList();
		public IReadOnlyList<Participant> FixedParticipants => GetFixedParticipants();


		public MasterPlan(long id, string name, DateRange fixedDates, IEnumerable<Participant> participants)
		{
			Id = id;
			Name = name;
			FixedDates = fixedDates ?? throw new ArgumentNullException(nameof(fixedDates));

			this.participants = participants?.ToList() ?? new List<Participant>();
		}

		private IReadOnlyList<Participant> GetFixedParticipants()
		{
			return participants
				.Where(x => FixedDates.IsOverlap(x.AssignmentDates))
				.ToList();
		}
	}
}