using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPlayerStatisticsEventExtensions
	{
		public static Task<String> TriggerStatsEventAsync(this BrainCloudPlayerStatisticsEvent self, String eventName, Int32 eventMultiplier)
		{
			var tcs = new TaskCompletionSource<String>();
			self.TriggerStatsEvent(
				eventName, eventMultiplier,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> TriggerStatsEventsAsync(this BrainCloudPlayerStatisticsEvent self, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.TriggerStatsEvents(
				jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}