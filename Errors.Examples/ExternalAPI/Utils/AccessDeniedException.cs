using System;

namespace Errors.Examples.ExternalAPI.Utils
{
	public class AccessDeniedException : Exception
	{
		public object Table { get; set; }
		public object Server { get; set; }
		public object Database { get; set; }
	}
}