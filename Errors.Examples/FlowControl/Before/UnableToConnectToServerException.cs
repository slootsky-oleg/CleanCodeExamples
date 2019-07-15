using System;

namespace Errors.Examples.FlowControl.Before
{
	public class UnableToConnectToServerException : Exception
	{
		public UnableToConnectToServerException(Exception exception)
		{
			throw new NotImplementedException();
		}
	}
}