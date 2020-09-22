using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudAsyncMatchExtensions
	{
		public static Task<String> CreateMatchAsync(this BrainCloudAsyncMatch self, String jsonOpponentIds, String pushNotificationMessage)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateMatch(
				jsonOpponentIds, pushNotificationMessage,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateMatchWithInitialTurnAsync(this BrainCloudAsyncMatch self, String jsonOpponentIds, String jsonMatchState, String pushNotificationMessage, String nextPlayer, String jsonSummary)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateMatchWithInitialTurn(
				jsonOpponentIds, jsonMatchState, pushNotificationMessage, nextPlayer, jsonSummary,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SubmitTurnAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId, UInt64 version, String jsonMatchState, String pushNotificationMessage, String nextPlayer, String jsonSummary, String jsonStatistics)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SubmitTurn(
				ownerId, matchId, version, jsonMatchState, pushNotificationMessage, nextPlayer, jsonSummary, jsonStatistics,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateMatchSummaryDataAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId, UInt64 version, String jsonSummary)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateMatchSummaryData(
				ownerId, matchId, version, jsonSummary,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CompleteMatchAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CompleteMatch(
				ownerId, matchId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadMatchAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadMatch(
				ownerId, matchId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadMatchHistoryAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadMatchHistory(
				ownerId, matchId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindMatchesAsync(this BrainCloudAsyncMatch self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindMatches(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindCompleteMatchesAsync(this BrainCloudAsyncMatch self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindCompleteMatches(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AbandonMatchAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AbandonMatch(
				ownerId, matchId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteMatchAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteMatch(
				ownerId, matchId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CompleteMatchWithSummaryDataAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId, String pushContent, String summary)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CompleteMatchWithSummaryData(
				ownerId, matchId, pushContent, summary,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AbandonMatchWithSummaryDataAsync(this BrainCloudAsyncMatch self, String ownerId, String matchId, String pushContent, String summary)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AbandonMatchWithSummaryData(
				ownerId, matchId, pushContent, summary,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}