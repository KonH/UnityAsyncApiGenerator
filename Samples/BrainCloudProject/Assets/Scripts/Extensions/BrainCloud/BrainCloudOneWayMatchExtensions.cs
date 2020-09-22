using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudOneWayMatchExtensions
	{
		public static Task<String> StartMatchAsync(this BrainCloudOneWayMatch self, String otherPlayerId, Int64 rangeDelta)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StartMatch(
				otherPlayerId, rangeDelta,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CancelMatchAsync(this BrainCloudOneWayMatch self, String playbackStreamId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CancelMatch(
				playbackStreamId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CompleteMatchAsync(this BrainCloudOneWayMatch self, String playbackStreamId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CompleteMatch(
				playbackStreamId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}