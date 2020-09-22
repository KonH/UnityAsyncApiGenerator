using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudDataStreamExtensions
	{
		public static Task<String> CustomPageEventAsync(this BrainCloudDataStream self, String eventName, String jsonEventProperties)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CustomPageEvent(
				eventName, jsonEventProperties,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CustomScreenEventAsync(this BrainCloudDataStream self, String eventName, String jsonEventProperties)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CustomScreenEvent(
				eventName, jsonEventProperties,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CustomTrackEventAsync(this BrainCloudDataStream self, String eventName, String jsonEventProperties)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CustomTrackEvent(
				eventName, jsonEventProperties,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SubmitCrashReportAsync(this BrainCloudDataStream self, String crashType, String errorMsg, String crashJson, String crashLog, String userName, String userEmail, String userNotes, Boolean userSubmitted)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SubmitCrashReport(
				crashType, errorMsg, crashJson, crashLog, userName, userEmail, userNotes, userSubmitted,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}