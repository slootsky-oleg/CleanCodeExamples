using System;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.Before
{
	public class ParticipantController
	{
		public Participant GetParticipant(long id)
		{
			try
			{
				var participantRepository = new ParticipantRepository("");
				var participant = participantRepository.Get(id);

				if (participant is null)
				{
					//return NotFound($"Participant with Id {id} not found")
				}

				if (!participant.IsSomething)
				{
					//return Invalid($"Participant with Id {id} is not valid")
				}

				return participant;
			}
			catch (Exception e)
			{
				Logger.Log("Error while executing command. See log for details.", e);
				//return 500 Internal server error
			}

			//only for demo
			throw new NotImplementedException();
		}
	}
}