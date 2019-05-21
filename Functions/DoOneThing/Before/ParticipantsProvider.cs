using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions.DoOneThing.Before
{
	public class ParticipantsProvider
	{
		public int GetNumberOfCourseParticipants(int ownerId)
		{
			var db = new DbManager("...");
			db.CreateCommand("[dbo].[spr_GetAllocations]");
			db.AddIntegerParameter("tpId", ownerId);
			var courses = db.ExecuteDataTable().To<IEnumerable<Course>>();

			int counter = 0;
			foreach (var course in courses)
			{
				var participants = course
					.Participants
					.Where(x => x.IsA && x.IsB || x.IsC);

				counter += participants.Count();

				if (course.Name.Length > 150)
					throw new InvalidOperationException($"Allocation {course.Id} Name is too long");
			}

			return counter;
		}
	}
}