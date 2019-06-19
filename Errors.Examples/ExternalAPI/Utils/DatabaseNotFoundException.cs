using System;

namespace Errors.Examples.ExternalAPI.Utils
{
	public class DatabaseNotFoundException : Exception
	{
		public object Database { get; set; }
		public object Server { get; set; }
	}
}