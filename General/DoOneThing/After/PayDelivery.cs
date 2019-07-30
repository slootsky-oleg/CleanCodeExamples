using System.Collections.Generic;

namespace General.DoOneThing.After
{
	public class PayDelivery
	{
		public void Pay(IEnumerable<Employee> employees)
		{
			foreach (var employee in employees)
				PayIfNecessary(employee);
		}

		private static void PayIfNecessary(Employee employee)
		{
			if (employee.IsPayday())
				CalculateAndDeliverPay(employee);
		}

		private static void CalculateAndDeliverPay(Employee employee)
		{
			Money payment = employee.CalculatePay();
			employee.DeliverPay(payment);
		}
	}
}