using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudChatExtensions
	{
		public static Task<String> ChannelConnectAsync(this BrainCloudChat self, String in_channelId, Int32 in_maxToReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ChannelConnect(
				in_channelId, in_maxToReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ChannelDisconnectAsync(this BrainCloudChat self, String in_channelId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ChannelDisconnect(
				in_channelId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_messageId, Int32 in_version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteChatMessage(
				in_channelId, in_messageId, in_version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetChannelIdAsync(this BrainCloudChat self, String in_channelType, String in_channelSubId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetChannelId(
				in_channelType, in_channelSubId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetChannelInfoAsync(this BrainCloudChat self, String in_channelId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetChannelInfo(
				in_channelId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_messageId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetChatMessage(
				in_channelId, in_messageId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRecentChatMessagesAsync(this BrainCloudChat self, String in_channelId, Int32 in_maxToReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRecentChatMessages(
				in_channelId, in_maxToReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSubscribedChannelsAsync(this BrainCloudChat self, String in_channelType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSubscribedChannels(
				in_channelType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_contentJson, Boolean in_recordInHistory)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostChatMessage(
				in_channelId, in_contentJson, in_recordInHistory,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_plain, String in_jsonRich, Boolean in_recordInHistory)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostChatMessage(
				in_channelId, in_plain, in_jsonRich, in_recordInHistory,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostChatMessageSimpleAsync(this BrainCloudChat self, String in_channelId, String in_plain, Boolean in_recordInHistory)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostChatMessageSimple(
				in_channelId, in_plain, in_recordInHistory,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_messageId, Int32 in_version, String in_contentJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateChatMessage(
				in_channelId, in_messageId, in_version, in_contentJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateChatMessageAsync(this BrainCloudChat self, String in_channelId, String in_messageId, Int32 in_version, String in_plain, String in_jsonRich)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateChatMessage(
				in_channelId, in_messageId, in_version, in_plain, in_jsonRich,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}