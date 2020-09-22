using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudMatchMakingExtensions
	{
		public static Task<String> ReadAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.Read(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SetPlayerRatingAsync(this BrainCloudMatchMaking self, Int64 playerRating)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SetPlayerRating(
				playerRating,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetPlayerRatingAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetPlayerRating(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementPlayerRatingAsync(this BrainCloudMatchMaking self, Int64 increment)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementPlayerRating(
				increment,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DecrementPlayerRatingAsync(this BrainCloudMatchMaking self, Int64 decrement)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DecrementPlayerRating(
				decrement,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> TurnShieldOnAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.TurnShieldOn(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> TurnShieldOnForAsync(this BrainCloudMatchMaking self, Int32 minutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.TurnShieldOnFor(
				minutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> TurnShieldOffAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.TurnShieldOff(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementShieldOnForAsync(this BrainCloudMatchMaking self, Int32 minutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementShieldOnFor(
				minutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetShieldExpiryAsync(this BrainCloudMatchMaking self, String playerId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetShieldExpiry(
				playerId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindPlayersAsync(this BrainCloudMatchMaking self, Int64 rangeDelta, Int64 numMatches)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindPlayers(
				rangeDelta, numMatches,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindPlayersWithAttributesAsync(this BrainCloudMatchMaking self, Int64 rangeDelta, Int64 numMatches, String jsonAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindPlayersWithAttributes(
				rangeDelta, numMatches, jsonAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindPlayersUsingFilterAsync(this BrainCloudMatchMaking self, Int64 rangeDelta, Int64 numMatches, String jsonExtraParms)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindPlayersUsingFilter(
				rangeDelta, numMatches, jsonExtraParms,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindPlayersWithAttributesUsingFilterAsync(this BrainCloudMatchMaking self, Int64 rangeDelta, Int64 numMatches, String jsonAttributes, String jsonExtraParms)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindPlayersWithAttributesUsingFilter(
				rangeDelta, numMatches, jsonAttributes, jsonExtraParms,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> EnableMatchMakingAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.EnableMatchMaking(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DisableMatchMakingAsync(this BrainCloudMatchMaking self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DisableMatchMaking(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}