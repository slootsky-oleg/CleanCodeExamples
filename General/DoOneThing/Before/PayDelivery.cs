using System.Collections.Generic;

namespace General.DoOneThing.Before
{
	public class PayDelivery
	{
		public void Pay(IEnumerable<Employee> employees)
		{
			foreach (var employee in employees)
			{
				if (employee.IsPayday())
				{
					Money payment = employee.CalculatePay();
					employee.DeliverPay(payment);
				}
			}
		}
	}
}