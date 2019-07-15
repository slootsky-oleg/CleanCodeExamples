using System;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After.Exceptions
{
	internal class InvalidParticipantException : Exception
	{
		public InvalidParticipantException(Participant participant)
			: base($"Invalid participant...")
		{
		}
	}
}