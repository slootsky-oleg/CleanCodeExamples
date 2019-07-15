using Errors.Examples.ExternalAPI.After.Core;
using Errors.Examples.ExternalAPI.After.Exceptions;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After
{
	public class GetParticipant
	{
		private readonly ParticipantRepository participantRepository;

		public GetParticipant(ParticipantRepository participantRepository)
		{
			this.participantRepository = participantRepository;
		}

		public Participant Execute(long id)
		{
			var participant = participantRepository.Get(id)
			                  ?? throw new ParticipantNotFoundException(id);

			Validate(participant);

			return participant;
		}

		private void Validate(Participant participant)
		{
			if (!participant.IsSomething)
			{
				throw new InvalidParticipantException(participant);
			}
		}
	}
}