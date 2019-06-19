using System;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.Before
{
	public class Demo
	{
		public void GetParticipant(long id)
		{
			try
			{
				var participantRepository = new ParticipantRepository();
				var participant = participantRepository.Get(id);
			}
			catch (Exception e)
			{
				Logger.Log("Error while executing command. See log for details.", e);
			}
		}
	}
}