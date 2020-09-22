using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudTournamentExtensions
	{
		public static Task<String> ClaimTournamentRewardAsync(this BrainCloudTournament self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ClaimTournamentReward(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetDivisionInfoAsync(this BrainCloudTournament self, String divSetId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetDivisionInfo(
				divSetId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMyDivisionsAsync(this BrainCloudTournament self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMyDivisions(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetTournamentStatusAsync(this BrainCloudTournament self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetTournamentStatus(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> JoinDivisionAsync(this BrainCloudTournament self, String divSetId, String tournamentCode, Int64 initialScore)
		{
			var tcs = new TaskCompletionSource<String>();
			self.JoinDivision(
				divSetId, tournamentCode, initialScore,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> JoinTournamentAsync(this BrainCloudTournament self, String leaderboardId, String tournamentCode, Int64 initialScore)
		{
			var tcs = new TaskCompletionSource<String>();
			self.JoinTournament(
				leaderboardId, tournamentCode, initialScore,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> LeaveDivisionInstanceAsync(this BrainCloudTournament self, String leaderboardId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.LeaveDivisionInstance(
				leaderboardId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> LeaveTournamentAsync(this BrainCloudTournament self, String leaderboardId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.LeaveTournament(
				leaderboardId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostTournamentScoreAsync(this BrainCloudTournament self, String leaderboardId, Int64 score, String jsonData, DateTime roundStartTimeLocal)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostTournamentScore(
				leaderboardId, score, jsonData, roundStartTimeLocal,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostTournamentScoreUTCAsync(this BrainCloudTournament self, String leaderboardId, Int64 score, String jsonData, UInt64 roundStartTimeUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostTournamentScoreUTC(
				leaderboardId, score, jsonData, roundStartTimeUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostTournamentScoreWithResultsAsync(this BrainCloudTournament self, String leaderboardId, Int64 score, String jsonData, DateTime roundStartTimeLocal, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount, Int64 initialScore)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostTournamentScoreWithResults(
				leaderboardId, score, jsonData, roundStartTimeLocal, sort, beforeCount, afterCount, initialScore,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PostTournamentScoreWithResultsUTCAsync(this BrainCloudTournament self, String leaderboardId, Int64 score, String jsonData, UInt64 roundStartTimeUTC, BrainCloudSocialLeaderboard.SortOrder sort, Int32 beforeCount, Int32 afterCount, Int64 initialScore)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PostTournamentScoreWithResultsUTC(
				leaderboardId, score, jsonData, roundStartTimeUTC, sort, beforeCount, afterCount, initialScore,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ViewCurrentRewardAsync(this BrainCloudTournament self, String leaderboardId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ViewCurrentReward(
				leaderboardId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ViewRewardAsync(this BrainCloudTournament self, String leaderboardId, Int32 versionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ViewReward(
				leaderboardId, versionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}