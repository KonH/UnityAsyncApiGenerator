using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPlaybackStreamExtensions
	{
		public static Task<String> StartStreamAsync(this BrainCloudPlaybackStream self, String targetPlayerId, Boolean includeSharedData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StartStream(
				targetPlayerId, includeSharedData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadStreamAsync(this BrainCloudPlaybackStream self, String playbackStreamId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadStream(
				playbackStreamId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> EndStreamAsync(this BrainCloudPlaybackStream self, String playbackStreamId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.EndStream(
				playbackStreamId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteStreamAsync(this BrainCloudPlaybackStream self, String playbackStreamId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteStream(
				playbackStreamId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AddEventAsync(this BrainCloudPlaybackStream self, String playbackStreamId, String eventData, String summary)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AddEvent(
				playbackStreamId, eventData, summary,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRecentStreamsForInitiatingPlayerAsync(this BrainCloudPlaybackStream self, String initiatingPlayerId, Int32 maxNumStreams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRecentStreamsForInitiatingPlayer(
				initiatingPlayerId, maxNumStreams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRecentStreamsForTargetPlayerAsync(this BrainCloudPlaybackStream self, String targetPlayerId, Int32 maxNumStreams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRecentStreamsForTargetPlayer(
				targetPlayerId, maxNumStreams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}