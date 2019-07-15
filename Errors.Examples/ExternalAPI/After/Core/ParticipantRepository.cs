using System;
using System.Data;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After.Core
{
	public class ParticipantRepository
	{
		private readonly string connectionString;

		public Participant Get(long id)
		{
			using (var connection = new LegacyConnectionAdapter(connectionString, 3, TimeSpan.FromSeconds(1)))
			{
				var dataTable = connection.Execute($"Select...{id}");
				return GetParticipant(dataTable);
			}
		}

		private Participant GetParticipant(DataTable dataTable)
		{
			throw new NotImplementedException();
		}
	}
}