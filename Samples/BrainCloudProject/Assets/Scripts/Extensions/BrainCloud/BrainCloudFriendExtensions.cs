using System.Threading.Tasks;
using BrainCloud;
using System;
using BrainCloud.Common;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudFriendExtensions
	{
		public static Task<String> FindUserByUniversalIdAsync(this BrainCloudFriend self, String searchText, Int32 maxResults)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUserByUniversalId(
				searchText, maxResults,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetProfileInfoForCredentialAsync(this BrainCloudFriend self, String externalId, AuthenticationType authenticationType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetProfileInfoForCredential(
				externalId, authenticationType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetProfileInfoForExternalAuthIdAsync(this BrainCloudFriend self, String externalId, String externalAuthType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetProfileInfoForExternalAuthId(
				externalId, externalAuthType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetExternalIdForProfileIdAsync(this BrainCloudFriend self, String profileId, String authenticationType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetExternalIdForProfileId(
				profileId, authenticationType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadFriendEntityAsync(this BrainCloudFriend self, String entityId, String friendId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadFriendEntity(
				entityId, friendId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadFriendsEntitiesAsync(this BrainCloudFriend self, String entityType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadFriendsEntities(
				entityType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadFriendUserStateAsync(this BrainCloudFriend self, String friendId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadFriendUserState(
				friendId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSummaryDataForProfileIdAsync(this BrainCloudFriend self, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSummaryDataForProfileId(
				profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindUsersByExactNameAsync(this BrainCloudFriend self, String searchText, Int32 maxResults)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUsersByExactName(
				searchText, maxResults,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindUserByExactUniversalIdAsync(this BrainCloudFriend self, String searchText)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUserByExactUniversalId(
				searchText,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindUsersBySubstrNameAsync(this BrainCloudFriend self, String searchText, Int32 maxResults)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUsersBySubstrName(
				searchText, maxResults,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListFriendsAsync(this BrainCloudFriend self, BrainCloudFriend.FriendPlatform friendPlatform, Boolean includeSummaryData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListFriends(
				friendPlatform, includeSummaryData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AddFriendsAsync<T1>(this BrainCloudFriend self, IList<String> profileIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AddFriends(
				profileIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveFriendsAsync<T1>(this BrainCloudFriend self, IList<String> profileIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveFriends(
				profileIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetUsersOnlineStatusAsync<T1>(this BrainCloudFriend self, IList<String> profileIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUsersOnlineStatus(
				profileIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindUsersByNameStartingWithAsync(this BrainCloudFriend self, String searchText, Int32 maxResults)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUsersByNameStartingWith(
				searchText, maxResults,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindUsersByUniversalIdStartingWithAsync(this BrainCloudFriend self, String searchText, Int32 maxResults)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindUsersByUniversalIdStartingWith(
				searchText, maxResults,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}