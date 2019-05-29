namespace ObjectsAndDataStructures.DataAbstraction.After
{
	public interface IVehicle
	{
		double PercentFuelRemaining { get; }
		void Drive(double distance);
	}
}