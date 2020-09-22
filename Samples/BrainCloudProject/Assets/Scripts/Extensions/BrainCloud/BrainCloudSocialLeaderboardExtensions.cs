using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudSocialLeaderboardExtensions
	{
		public static Task<String> GetSocialLeaderboardAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Boolean replaceName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSocialLeaderboard(
				leaderboardId, replaceName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSocialLeaderboardByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Boolean replaceName, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSocialLeaderboardByVersion(
				leaderboardId, replaceName, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMultiSocialLeaderboardAsync<T1>(this BrainCloudSocialLeaderboard self, IList<String> leaderboardIds, Int32 leaderboardResultCount, Boolean replaceName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMultiSocialLeaderboard(
				leaderboardIds, leaderboardResultCount, replaceName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardPageAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 startIndex, Int32 endIndex)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardPage(
				leaderboardId, sort, startIndex, endIndex,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardPageByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 startIndex, Int32 endIndex, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardPageByVersion(
				leaderboardId, sort, startIndex, endIndex, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardViewAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardView(
				leaderboardId, sort, beforeCount, afterCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardViewByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardViewByVersion(
				leaderboardId, sort, beforeCount, afterCount, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardVersionsAsync(this BrainCloudSocialLeaderboard self, String leaderboardId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardVersions(
				leaderboardId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGroupSocialLeaderboardAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGroupSocialLeaderboard(
				leaderboardId, groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGroupSocialLeaderboardByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGroupSocialLeaderboardByVersion(
				leaderboardId, groupId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToLeaderboardAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Int64 score, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToLeaderboard(
				leaderboardId, score, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemovePlayerScoreAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemovePlayerScore(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicLeaderboardAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, BrainCloudSocialLeaderboard.RotationType rotationType, Nullable<DateTime> rotationResetUTC, Int32 retainedCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicLeaderboard(
				leaderboardId, score, jsonData, leaderboardType, rotationType, rotationResetUTC, retainedCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicLeaderboardUTCAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, BrainCloudSocialLeaderboard.RotationType rotationType, UInt64 rotationResetUTC, Int32 retainedCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicLeaderboardUTC(
				leaderboardId, score, jsonData, leaderboardType, rotationType, rotationResetUTC, retainedCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicGroupLeaderboardAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, BrainCloudSocialLeaderboard.RotationType rotationType, Nullable<DateTime> rotationResetUTC, Int32 retainedCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicGroupLeaderboard(
				leaderboardId, groupId, score, jsonData, leaderboardType, rotationType, rotationResetUTC, retainedCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicGroupLeaderboardUTCAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, BrainCloudSocialLeaderboard.RotationType rotationType, Nullable<UInt64> rotationResetUTC, Int32 retainedCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicGroupLeaderboardUTC(
				leaderboardId, groupId, score, jsonData, leaderboardType, rotationType, rotationResetUTC, retainedCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicLeaderboardDaysAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, Nullable<DateTime> rotationResetUTC, Int32 retainedCount, Int32 numDaysToRotate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicLeaderboardDays(
				leaderboardId, score, jsonData, leaderboardType, rotationResetUTC, retainedCount, numDaysToRotate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToDynamicLeaderboardDaysUTCAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, Int64 score, String jsonData, BrainCloudSocialLeaderboard.SocialLeaderboardType leaderboardType, Nullable<UInt64> rotationResetUTC, Int32 retainedCount, Int32 numDaysToRotate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToDynamicLeaderboardDaysUTC(
				leaderboardId, score, jsonData, leaderboardType, rotationResetUTC, retainedCount, numDaysToRotate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPlayersSocialLeaderboardAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, IList<String> profileIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPlayersSocialLeaderboard(
				leaderboardId, profileIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPlayersSocialLeaderboardByVersionAsync<T1>(this BrainCloudSocialLeaderboard self, String leaderboardId, IList<String> profileIds, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPlayersSocialLeaderboardByVersion(
				leaderboardId, profileIds, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListLeaderboardsAsync(this BrainCloudSocialLeaderboard self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListLeaderboards(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardEntryCountAsync(this BrainCloudSocialLeaderboard self, String leaderboardId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardEntryCount(
				leaderboardId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalLeaderboardEntryCountByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalLeaderboardEntryCountByVersion(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPlayerScoreAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPlayerScore(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPlayerScoresFromLeaderboardsAsync<T1>(this BrainCloudSocialLeaderboard self, IList<String> leaderboardIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPlayerScoresFromLeaderboards(
				leaderboardIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostScoreToGroupLeaderboardAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int32 score, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostScoreToGroupLeaderboard(
				leaderboardId, groupId, score, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveGroupScoreAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveGroupScore(
				leaderboardId, groupId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGroupLeaderboardViewAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGroupLeaderboardView(
				leaderboardId, groupId, sort, beforeCount, afterCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGroupLeaderboardViewByVersionAsync(this BrainCloudSocialLeaderboard self, String leaderboardId, String groupId, Int32 versionId, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGroupLeaderboardViewByVersion(
				leaderboardId, groupId, versionId, sort, beforeCount, afterCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}