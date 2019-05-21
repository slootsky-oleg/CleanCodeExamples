namespace Functions.SideEffects.After
{
	public class Activity
	{
		public int Id { get; }
		public string Name { get; }

		public Activity(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}