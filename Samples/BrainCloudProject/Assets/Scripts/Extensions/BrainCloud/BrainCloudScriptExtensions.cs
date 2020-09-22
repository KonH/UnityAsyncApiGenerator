using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudScriptExtensions
	{
		public static Task<String> RunScriptAsync(this BrainCloudScript self, String scriptName, String jsonScriptData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RunScript(
				scriptName, jsonScriptData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRunScriptUTCAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, DateTime startDateLocal)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRunScriptUTC(
				scriptName, jsonScriptData, startDateLocal,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRunScriptMillisUTCAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, UInt64 roundStartTimeUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRunScriptMillisUTC(
				scriptName, jsonScriptData, roundStartTimeUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRunScriptMinutesAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, Int64 minutesFromNow)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRunScriptMinutes(
				scriptName, jsonScriptData, minutesFromNow,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RunParentScriptAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, String parentLevel)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RunParentScript(
				scriptName, jsonScriptData, parentLevel,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CancelScheduledScriptAsync(this BrainCloudScript self, String jobId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CancelScheduledScript(
				jobId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetScheduledCloudScriptsAsync(this BrainCloudScript self, DateTime startDateUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetScheduledCloudScripts(
				startDateUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRunningOrQueuedCloudScriptsAsync(this BrainCloudScript self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRunningOrQueuedCloudScripts(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RunPeerScriptAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, String peer)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RunPeerScript(
				scriptName, jsonScriptData, peer,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RunPeerScriptAsyncAsync(this BrainCloudScript self, String scriptName, String jsonScriptData, String peer)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RunPeerScriptAsync(
				scriptName, jsonScriptData, peer,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}