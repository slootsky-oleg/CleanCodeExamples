using System.Linq;

namespace Functions.DoOneThing.After
{
	public class ParticipantsProvider
	{
		private readonly ICourseRepository courseRepository;

		public ParticipantsProvider(ICourseRepository courseRepository)
		{
			this.courseRepository = courseRepository;
		}

		public int GetCountOfActiveParticipants(OrganizationalUnit organizationalUnit)
		{
			var courses = courseRepository.GetByOwner(organizationalUnit);

			return courses
				.Select(c => c.ActiveParticipants.Count)
				.Sum();
		}
	}
}