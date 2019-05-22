namespace Comments.CommentToVariable
{
	public class CommentToFunction
	{
		public void Linq()
		{
			BEFORE:
			//get candidates whose training position was chaged
			var toUpdateTrainingPos = (from toReg in candidates
				join exists in participants on toReg.ID equals exists.ID
				where toReg.EntityType == Entity.EntitiesTypes.User && toReg.TrainingPositionID != exists.PositionID
				select toReg).ToList();

			AFTER:
			var changedTrainingPositions = GetChangedTrainingPositions(candidates, participants,...);



			BEFORE:
			var filteredEvents = events
				.AsEnumerable()
				.Where(dr => !eventIDs.Contains(dr.GetNumericProperty("CalID")) && !eventIDs.Contains(dr.GetNumericProperty("CollectionID")));

			AFTER:
			var filteredEvents = events
				.AsEnumerable()
				.Where(dr => !EventAlreadyProcessed(eventIDs, dr));
		}
	}
}