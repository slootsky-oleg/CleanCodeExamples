using System;

namespace Functions.Test.Answers.Core
{
	public class Participant
	{
		public int Id { get; }
		public string Name { get; }
		public DateRange AssignmentDates { get; }

		public Participant(int id, string name, DateRange assignmentDates)
		{
			Id = id;
			Name = name;

			AssignmentDates = assignmentDates
				?? throw new ArgumentNullException(nameof(assignmentDates));
		}
	}
}