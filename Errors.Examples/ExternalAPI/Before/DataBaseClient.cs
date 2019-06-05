using System;
using System.Data.SqlClient;

namespace Errors.Examples.ExternalAPI.Before
{
	public class Demo
	{
		public void Execute()
		{
			try
			{
				using (var connection = new LegacyDatabaseConnection("..."))
				{
					//DoSomething();
				}
			}
			catch (DatabaseNotFoundException e)
			{
				Logger.Log($"DB {e.Database} not found in server {e.Server}.");
			}
			catch (AccessDeniedException e)
			{
				//We know that actual reason is size of a table
				Logger.Log($"Table {e.Table} size exceeded in {e.Server}.{e.Database}");
			}
			catch (InvalidSQLOperationException e) when (e.Code == "SQL_BUSY")
			{
				//another database connection is using the database
				//Retry();
			}
			catch (InvalidSQLOperationException e)
			{
				Logger.Log("");
			}
			catch (TimeoutException e)
			{
				//Retry();
			}

		}
	}

	public class InvalidSQLOperationException : Exception
	{
		public string Code { get; set; }
	}

	public class Logger
	{
		public static void Log(string s)
		{
			throw new NotImplementedException();
		}
	}

	public class AccessDeniedException : Exception
	{
		public object Table { get; set; }
		public object Server { get; set; }
		public object Database { get; set; }
	}

	public class DatabaseNotFoundException : Exception
	{
		public object Database { get; set; }
		public object Server { get; set; }
	}

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
	}
}