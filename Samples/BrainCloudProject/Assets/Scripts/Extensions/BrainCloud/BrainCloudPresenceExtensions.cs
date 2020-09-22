using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPresenceExtensions
	{
		public static Task<String> ForcePushAsync(this BrainCloudPresence self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ForcePush(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPresenceOfFriendsAsync(this BrainCloudPresence self, String platform, Boolean includeOffline)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPresenceOfFriends(
				platform, includeOffline,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPresenceOfGroupAsync(this BrainCloudPresence self, String groupId, Boolean includeOffline)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPresenceOfGroup(
				groupId, includeOffline,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPresenceOfUsersAsync<T1>(this BrainCloudPresence self, List<String> profileIds, Boolean includeOffline)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPresenceOfUsers(
				profileIds, includeOffline,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RegisterListenersForFriendsAsync(this BrainCloudPresence self, String platform, Boolean bidirectional)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RegisterListenersForFriends(
				platform, bidirectional,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RegisterListenersForGroupAsync(this BrainCloudPresence self, String groupId, Boolean bidirectional)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RegisterListenersForGroup(
				groupId, bidirectional,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RegisterListenersForProfilesAsync<T1>(this BrainCloudPresence self, List<String> profileIds, Boolean bidirectional)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RegisterListenersForProfiles(
				profileIds, bidirectional,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SetVisibilityAsync(this BrainCloudPresence self, Boolean visible)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SetVisibility(
				visible,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> StopListeningAsync(this BrainCloudPresence self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StopListening(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateActivityAsync(this BrainCloudPresence self, String jsonActivity)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateActivity(
				jsonActivity,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}