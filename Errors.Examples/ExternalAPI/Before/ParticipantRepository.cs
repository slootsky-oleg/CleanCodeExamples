using System;
using System.Data;
using System.Data.SqlClient;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.Before
{
	public class ParticipantRepository
	{
		private readonly string connectionString;

		public ParticipantRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public Participant Get(long id)
		{
			try
			{
				using (var connection = new LegacyDatabaseConnection(connectionString))
				{
					var dataTable = connection.Execute($"Select...{id}");
					return GetParticipant(dataTable);
				}
			}
			catch (DatabaseNotFoundException e)
			{
				Logger.Log($"DB {e.Database} not found in server {e.Server}.");
				throw;
				//throw e;
			}
			catch (AccessDeniedException e)
			{
				//We know that actual reason is size of a table
				Logger.Log($"Table {e.Table} size exceeded in {e.Server}.{e.Database}");
				throw;
			}
			catch (InvalidSQLOperationException e) when (e.Code == "SQL_BUSY")
			{
				//another connection is using the database
				//Retry;
				return Get(id);
			}
			catch (InvalidSQLOperationException e)
			{
				Logger.Log(e.Message);
				throw;
			}
			catch (TimeoutException e)
			{
				//Retry
				return Get(id);
			}
		}

		private Participant GetParticipant(DataTable dataTable)
		{
			throw new NotImplementedException();
		}
	}
}