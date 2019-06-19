using System;
using System.Data;

namespace Errors.Examples.ExternalAPI.Utils
{
	public class LegacyDatabaseConnection : IDisposable
	{
		public LegacyDatabaseConnection(string s)
		{
		}

		public void Dispose()
		{
		}

		public void Open()
		{
			throw new NotImplementedException();
		}

		public DataTable Execute(string query)
		{
			throw new NotImplementedException();
		}
	}
}