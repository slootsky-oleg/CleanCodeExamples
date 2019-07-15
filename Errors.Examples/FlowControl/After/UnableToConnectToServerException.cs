using System;

namespace Errors.Examples.FlowControl.After
{
	public class UnableToConnectToServerException : Exception
	{
		public UnableToConnectToServerException(Exception exception)
		{
			throw new NotImplementedException();
		}
	}
}