using System.Collections.Generic;
using System.Linq;

namespace Functions.DoOneThing.Before
{
	public class Course
	{
		public string Name { get; }
		public int Id { get; }

		public IReadOnlyList<Participant> Participants { get; }

		public Course(int id, string name, IEnumerable<Participant> participants)
		{
			Id = id;
			Name = name;
			Participants = participants.ToList();
		}
	}
}