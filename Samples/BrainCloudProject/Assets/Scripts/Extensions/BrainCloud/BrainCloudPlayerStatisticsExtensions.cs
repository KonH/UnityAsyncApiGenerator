using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPlayerStatisticsExtensions
	{
		public static Task<String> ReadAllUserStatsAsync(this BrainCloudPlayerStatistics self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadAllUserStats(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadUserStatsSubsetAsync<T1>(this BrainCloudPlayerStatistics self, IList<String> playerStats)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadUserStatsSubset(
				playerStats,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadUserStatsForCategoryAsync(this BrainCloudPlayerStatistics self, String category)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadUserStatsForCategory(
				category,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetAllUserStatsAsync(this BrainCloudPlayerStatistics self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetAllUserStats(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementUserStatsAsync(this BrainCloudPlayerStatistics self, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementUserStats(
				jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementUserStatsAsync<T1, T2>(this BrainCloudPlayerStatistics self, Dictionary<String, Object> dictData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementUserStats(
				dictData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProcessStatisticsAsync(this BrainCloudPlayerStatistics self, String statisticsData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProcessStatistics(
				statisticsData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProcessStatisticsAsync<T1, T2>(this BrainCloudPlayerStatistics self, Dictionary<String, Object> statisticsData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProcessStatistics(
				statisticsData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetNextExperienceLevelAsync(this BrainCloudPlayerStatistics self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetNextExperienceLevel(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementExperiencePointsAsync(this BrainCloudPlayerStatistics self, Int32 xpValue)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementExperiencePoints(
				xpValue,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SetExperiencePointsAsync(this BrainCloudPlayerStatistics self, Int32 xpValue)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SetExperiencePoints(
				xpValue,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}