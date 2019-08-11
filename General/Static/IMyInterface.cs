namespace General.Static
{
	public interface IMyInterface
	{
		int GetSize();
	}

	public class MyClass : IMyInterface
	{
		public /*static*/ int GetSize()
		{
			throw new System.NotImplementedException();
		}

		public static void Do()
		{

		}
	}

	public class MyClassInherited : MyClass
	{
		public static void DoNext()
		{
			Do();
		}
	}
}