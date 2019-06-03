using System.Linq;
using System.Web.Http;
using Functions.Test.Answers.API.Exceptions;
using Functions.Test.Answers.API.Models.Common;
using Functions.Test.Answers.API.Models.MasterPlans;
using Functions.Test.Answers.API.Models.MasterPlans.Participants;
using Functions.Test.Answers.API.Models.MasterPlans.Single;
using Functions.Test.Answers.Core;
using Functions.Test.Answers.Core.SinglePropertySet;

namespace Functions.Test.Answers.API.Controllers
{
	public class SingleMasterPlanController : ApiController
	{
		private readonly IMasterPlanRepository masterPlanRepository;

		public SingleMasterPlanController(IMasterPlanRepository masterPlanRepository)
		{
			this.masterPlanRepository = masterPlanRepository;
		}

		public IHttpActionResult Get(long id)
		{
			var masterPlan = GetMasterPlan(id);

			var masterPlanDto = new MasterPlanDto(masterPlan);

			return Ok(masterPlanDto);
		}

		public IHttpActionResult GetPopupInfo(long id)
		{
			var masterPlan = GetMasterPlan(id);

			var masterPlanPopUpDto = new MasterPlanPopUpDto(masterPlan);

			return Ok(masterPlanPopUpDto);
		}

		public IHttpActionResult GetFixedParticipants(long id)
		{
			var masterPlan = GetMasterPlan(id);
			var fixedDates = new DateRangeDto(masterPlan.FixedDates);

			//var builder = new FixedParticipantBuilder(masterPlan);

			var participantsDto = masterPlan
					.FixedParticipants
					//.Select(builder.Build);
					.Select(x => new FixedParticipantDto(x, fixedDates));

			return Ok(participantsDto);
		}


		private MasterPlan GetMasterPlan(long id)
		{
			return masterPlanRepository.Get(id)
			                 ?? throw new MasterPlanNotFoundException(id);
		}
	}
}