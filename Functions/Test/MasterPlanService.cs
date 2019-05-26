using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Functions.Test
{
	public class MasterPlanService
	{
		public MasterPlan GetMasterPlanById(int id, bool includeParticipants, out List<Participant> participants)
		{
			MasterPlan masterP = null;
			participants = null;

			var tableMp = new DataTable("MasterPlans");
			var mp = tableMp
				.Select($"Id = {id}")
				.SingleOrDefault();

			if (mp != null)
			{
				masterP = new MasterPlan
				{
					Id = (int) mp["Id"],
					Name = (string) mp["Name"],
					FixedStart = (DateTime) mp["FixedStart"],
					FixedEnd = (DateTime) mp["FixedEnd"],
				};


				var tableParticipants = new DataTable("Participants");
				participants = tableParticipants
					.Select($"OwnerId = {masterP.Id}")
					.Select(dataRow => new Participant
				             {
					             Id = (int) dataRow["Id"],
					             Name = (string) dataRow["Name"],
					             AssignedFrom = (DateTime) mp["AssignedFrom"],
					             AssignedTo = (DateTime) mp["AssignedTo"],
				             })
					.ToList();
			}

			return masterP;
		}

		public List<Participant> GetParticipants(bool onlyFixedParticipants, List<Participant> participants, DateTime? fixedStart, DateTime? fixedEnd)
		{
			if (onlyFixedParticipants)
			{
				participants.RemoveAll(x => !(x.AssignedTo >= fixedStart && x.AssignedFrom <= fixedEnd));
			}

			var result = new List<Participant>();
			foreach (var participant in participants)
			{
				if (onlyFixedParticipants)
				{
					if (fixedStart is null || fixedEnd is null)
					{
						throw new ArgumentNullException();
					}

					if (participant.AssignedTo >= fixedStart && participant.AssignedFrom <= fixedEnd)
					{
						participant.AssignedFrom = fixedStart.Value;
						participant.AssignedTo = fixedEnd.Value;
						result.Add(participant);
					}
				}
				else
				{
					participant.AssignedFrom = DateTime.MinValue;
					participant.AssignedTo = DateTime.MaxValue;
				}
			}

			return result;
		}
	}
}