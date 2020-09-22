using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGlobalStatisticsExtensions
	{
		public static Task<String> ReadAllGlobalStatsAsync(this BrainCloudGlobalStatistics self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadAllGlobalStats(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGlobalStatsSubsetAsync<T1>(this BrainCloudGlobalStatistics self, IList<String> globalStats)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGlobalStatsSubset(
				globalStats,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGlobalStatsForCategoryAsync(this BrainCloudGlobalStatistics self, String category)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGlobalStatsForCategory(
				category,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementGlobalStatsAsync(this BrainCloudGlobalStatistics self, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementGlobalStats(
				jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProcessStatisticsAsync(this BrainCloudGlobalStatistics self, String statisticsData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProcessStatistics(
				statisticsData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProcessStatisticsAsync<T1, T2>(this BrainCloudGlobalStatistics self, Dictionary<String, Object> statisticsData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProcessStatistics(
				statisticsData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}