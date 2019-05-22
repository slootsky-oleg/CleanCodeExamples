namespace Names
{
	public class ActivityManager
	{
		private int l = 50;

		public string actNameInTP; //Activity name in the training program
		public string actNameInST; //Activity name in the source template
		public string actNameInBL; //Activity name in the base line

		public string GetActualActNameByItsNameSource()
		{
			if (!string.IsNullOrWhiteSpace(actNameInTP))
			{
				return actNameInTP;
			}
			else if (!string.IsNullOrWhiteSpace(actNameInST))
			{
				return actNameInST;
			}
			else if (!string.IsNullOrWhiteSpace(actNameInBL))
			{
				return actNameInBL;
			}

			return string.Empty;
		}

		public string GetActualActNameByItsNameSourceLeftSymbols()
		{
			var n = string.Empty;

			if (!string.IsNullOrWhiteSpace(actNameInTP))
			{
				n = actNameInTP.ToLower();
			}
			else if (!string.IsNullOrWhiteSpace(actNameInST))
			{
				n = actNameInST.ToLower();
			}
			else if (!string.IsNullOrWhiteSpace(actNameInBL))
			{
				n =actNameInBL.ToLower();
			}

			return n.Substring(0, l);
		}
	}

	public class ActivityManagerDemo
	{
		public void Demo()
		{
			var manager = new ActivityManager
			{
				actNameInST = "name in Source template"
			};

			var name = manager.GetActualActNameByItsNameSource();
			var shortName = manager.GetActualActNameByItsNameSourceLeftSymbols();
		}
	}
}