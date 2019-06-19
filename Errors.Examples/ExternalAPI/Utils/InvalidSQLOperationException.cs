using System;

namespace Errors.Examples.ExternalAPI.Utils
{
	public class InvalidSQLOperationException : Exception
	{
		public string Code { get; set; }
	}
}