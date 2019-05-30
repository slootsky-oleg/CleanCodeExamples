namespace ObjectsAndDataStructures.DataAbstraction.HideDetails
{
	public interface IVehicle
	{
		double PercentFuelRemaining { get; }
		void Drive(double distance);
	}
}