using System;
using System.Runtime.Remoting.Messaging;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After
{
	public class Demo
	{
		public void GetParticipant(long id)
		{
			var participantRepository = new ParticipantRepository();

			try
			{
				var participant = participantRepository.Get(id);

				if (participant is null)
				{
					//return 404 Not Found Error
				}
			}
			catch (Exception e)
			{
				Logger.Log(e.Message);

				//return 500 Internal Server Error
			}
		}
	}
}