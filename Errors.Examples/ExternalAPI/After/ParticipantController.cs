using System;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Errors.Examples.ExternalAPI.After.Core;
using Errors.Examples.ExternalAPI.After.Exceptions;
using Errors.Examples.ExternalAPI.Utils;

namespace Errors.Examples.ExternalAPI.After
{
	public class ParticipantController
	{
		private readonly ParticipantRepository participantRepository;

		public IHttpActionResult GetParticipant(long id)
		{
			try
			{
				var getParticipant = new GetParticipant(participantRepository);
				var participant = getParticipant.Execute(id);

				return Ok(participant);
			}
			catch (LegacyConnectionAdapterException e)
			{
				Logger.Log(e.Message);
				return ServiceUnavailable();
			}
			catch (ParticipantNotFoundException e)
			{
				Logger.Log(e.Message);
				return NotFoundResult(e.Message);
			}
			catch (InvalidParticipantException e)
			{
				Logger.Log(e.Message);
				return BadRequest(e.Message);
			}
			catch (Exception e)
			{
				Logger.Log(e.Message);
				return InternalServerErrorResult();
			}
		}

		#region Service
		
		private IHttpActionResult InternalServerErrorResult()
		{
			throw new NotImplementedException();
		}

		private IHttpActionResult BadRequest(string s)
		{
			throw new NotImplementedException();
		}

		private IHttpActionResult ServiceUnavailable()
		{
			throw new NotImplementedException();
		}

		private IHttpActionResult Ok(Participant participant)
		{
			throw new NotImplementedException();
		}

		private IHttpActionResult NotFoundResult(string eMessage)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}