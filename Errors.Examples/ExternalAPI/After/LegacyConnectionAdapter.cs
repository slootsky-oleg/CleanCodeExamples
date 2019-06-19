using System;
using System.Data;
using System.Threading;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After
{
	public class LegacyConnectionAdapter : IDisposable
	{
		private readonly string connectionString;
		private readonly int maxRetryAttempts;
		private readonly TimeSpan retryInterval;
		private int retryAttempts;

		public LegacyConnectionAdapter(string connectionString, int maxRetryAttempts, TimeSpan retryInterval)
		{
			this.retryAttempts = 0;

			this.connectionString = connectionString
			                        ?? throw new ArgumentNullException(nameof(connectionString));

			if (maxRetryAttempts < 1)
				throw new ArgumentOutOfRangeException(nameof(maxRetryAttempts), "Should be greater than 0.");

			this.maxRetryAttempts = maxRetryAttempts;
			this.retryInterval = retryInterval;
		}

		public DataTable Execute(string query)
		{
			for (var attempted = 0; attempted < maxRetryAttempts; attempted++)
			{
				if (attempted > 0)
					Thread.Sleep(retryInterval);

				try
				{
					return ExecuteQuery(query);
				}
				catch (DatabaseNotFoundException e)
				{
					throw new LegacyConnectionAdapterException($"DB {e.Database} not found in server {e.Server}.");
				}
				catch (AccessDeniedException e)
				{
					//We know that actual reason is size of a table
					throw new LegacyConnectionAdapterException($"Table {e.Table} size exceeded in {e.Server}.{e.Database}.");
				}
				catch (TimeoutException)
				{
					//Retry
				}
				catch (InvalidSQLOperationException e) when (e.Code == "SQL_BUSY")
				{
					//Another connection is using the database
					//Retry
				}
				catch (InvalidSQLOperationException)
				{
					throw new LegacyConnectionAdapterException("Unknown sql exception.");
				}
			}

			throw new LegacyConnectionAdapterException("Maximum retries number exceeded.");
		}

		private DataTable ExecuteQuery(string query)
		{
			using (var connection = new LegacyDatabaseConnection(connectionString))
			{
				return connection.Execute(query);
			}
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}