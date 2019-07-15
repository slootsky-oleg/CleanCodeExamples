using System;

namespace Errors.Examples.ExternalAPI.After.Exceptions
{
	internal class ParticipantNotFoundException : Exception
	{
		public long Id { get; }

		public ParticipantNotFoundException(long id)
			: base($"Participant with Id {id} not found")
		{
			Id = id;
		}
	}
}