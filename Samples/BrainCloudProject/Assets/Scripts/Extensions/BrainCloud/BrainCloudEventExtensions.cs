using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudEventExtensions
	{
		public static Task<String> SendEventAsync(this BrainCloudEvent self, String toProfileId, String eventType, String jsonEventData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendEvent(
				toProfileId, eventType, jsonEventData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateIncomingEventDataAsync(this BrainCloudEvent self, String evId, String jsonEventData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateIncomingEventData(
				evId, jsonEventData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteIncomingEventAsync(this BrainCloudEvent self, String evId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteIncomingEvent(
				evId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEventsAsync(this BrainCloudEvent self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEvents(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}