using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudMessagingExtensions
	{
		public static Task<String> DeleteMessagesAsync(this BrainCloudMessaging self, String in_msgBox, String[] in_msgsIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteMessages(
				in_msgBox, in_msgsIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMessageboxesAsync(this BrainCloudMessaging self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMessageboxes(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMessageCountsAsync(this BrainCloudMessaging self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMessageCounts(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMessagesAsync(this BrainCloudMessaging self, String in_msgBox, String[] in_msgsIds, Boolean markAsRead)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMessages(
				in_msgBox, in_msgsIds, markAsRead,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMessagesPageAsync(this BrainCloudMessaging self, String in_context)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMessagesPage(
				in_context,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMessagesPageOffsetAsync(this BrainCloudMessaging self, String in_context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMessagesPageOffset(
				in_context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MarkMessagesReadAsync(this BrainCloudMessaging self, String in_msgBox, String[] in_msgsIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MarkMessagesRead(
				in_msgBox, in_msgsIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendMessageAsync(this BrainCloudMessaging self, String[] in_toProfileIds, String in_contentJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendMessage(
				in_toProfileIds, in_contentJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendMessageSimpleAsync(this BrainCloudMessaging self, String[] in_toProfileIds, String in_messageText)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendMessageSimple(
				in_toProfileIds, in_messageText,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}