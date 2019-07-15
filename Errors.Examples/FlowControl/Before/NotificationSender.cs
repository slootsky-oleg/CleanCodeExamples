using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Errors.Examples.FlowControl.Before
{
	public class NotificationSender
	{
		private readonly HttpClient httpClient;

		public async void Send(string endpointUrl)
		{
			try
			{
				await SendNotification(endpointUrl);
				MarkNotificationAsSent();
			}

			catch (UnableToConnectToServerException)
			{
				MarkNotificationAsNotSent();
			}
		}

		private async Task SendNotification(string endpointUrl)
		{
			try
			{
				var message = await httpClient.PostAsync(endpointUrl, null);
				var response = await message.Content.ReadAsStringAsync();
				/* do something with the response */
			}
			catch (Exception ex)
			{
				throw new UnableToConnectToServerException(ex);
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