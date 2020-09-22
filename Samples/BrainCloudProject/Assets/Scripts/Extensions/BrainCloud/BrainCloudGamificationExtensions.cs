using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGamificationExtensions
	{
		public static Task<String> ReadAllGamificationAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadAllGamification(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadMilestonesAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadMilestones(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadAchievementsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadAchievements(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadXpLevelsMetaDataAsync(this BrainCloudGamification self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadXpLevelsMetaData(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadAchievedAchievementsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadAchievedAchievements(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadCompletedMilestonesAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadCompletedMilestones(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadInProgressMilestonesAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadInProgressMilestones(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadMilestonesByCategoryAsync(this BrainCloudGamification self, String category, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadMilestonesByCategory(
				category, includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AwardAchievementsAsync<T1>(this BrainCloudGamification self, IList<String> achievementIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AwardAchievements(
				achievementIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadQuestsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadQuests(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadCompletedQuestsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadCompletedQuests(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadInProgressQuestsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadInProgressQuests(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadNotStartedQuestsAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadNotStartedQuests(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadQuestsWithStatusAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadQuestsWithStatus(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadQuestsWithBasicPercentageAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadQuestsWithBasicPercentage(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadQuestsWithComplexPercentageAsync(this BrainCloudGamification self, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadQuestsWithComplexPercentage(
				includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadQuestsByCategoryAsync(this BrainCloudGamification self, String category, Boolean includeMetaData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadQuestsByCategory(
				category, includeMetaData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetMilestonesAsync<T1>(this BrainCloudGamification self, IList<String> milestoneIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetMilestones(
				milestoneIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}