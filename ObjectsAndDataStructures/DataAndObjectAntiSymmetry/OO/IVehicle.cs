using ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO
{
	public interface IVehicle
	{
		double PercentFuelRemaining { get; }
		void Drive(double distance);
		void FillTank(FuelVolume volume);
	}
}