using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Errors.Examples.FlowControl.After
{
	public class NotificationSender
	{
		private readonly HttpClient httpClient;

		public NotificationSender(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}


		public async void Send(string endpointUrl)
		{
			if (await TrySendNotification(endpointUrl))
			{
				MarkNotificationAsSent();
			}
			else
			{
				MarkNotificationAsNotSent();
			}
		}

		private async Task<bool> TrySendNotification(string endpointUrl)
		{
			try
			{
				var message = await httpClient.PostAsync(endpointUrl, null);
				var response = await message.Content.ReadAsStringAsync();
				/* do something with the response */
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		private void MarkNotificationAsNotSent()
		{
			throw new NotImplementedException();
		}

		private void MarkNotificationAsSent()
		{
			throw new NotImplementedException();
		}
	}
}