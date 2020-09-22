using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudLobbyExtensions
	{
		public static Task<String> FindLobbyAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Int32 in_maxSteps, Dictionary<String, Object> in_algo, Dictionary<String, Object> in_filterJson, Int32 in_timeoutSecs, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindLobby(
				in_roomType, in_rating, in_maxSteps, in_algo, in_filterJson, in_timeoutSecs, in_isReady, in_extraJson, in_teamCode, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindLobbyWithPingDataAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Int32 in_maxSteps, Dictionary<String, Object> in_algo, Dictionary<String, Object> in_filterJson, Int32 in_timeoutSecs, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindLobbyWithPingData(
				in_roomType, in_rating, in_maxSteps, in_algo, in_filterJson, in_timeoutSecs, in_isReady, in_extraJson, in_teamCode, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateLobbyAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, Dictionary<String, Object> in_settings, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateLobby(
				in_roomType, in_rating, in_isReady, in_extraJson, in_teamCode, in_settings, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateLobbyWithPingDataAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, Dictionary<String, Object> in_settings, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateLobbyWithPingData(
				in_roomType, in_rating, in_isReady, in_extraJson, in_teamCode, in_settings, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindOrCreateLobbyAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Int32 in_maxSteps, Dictionary<String, Object> in_algo, Dictionary<String, Object> in_filterJson, Int32 in_timeoutSecs, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, Dictionary<String, Object> in_settings, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindOrCreateLobby(
				in_roomType, in_rating, in_maxSteps, in_algo, in_filterJson, in_timeoutSecs, in_isReady, in_extraJson, in_teamCode, in_settings, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FindOrCreateLobbyWithPingDataAsync<T1, T2>(this BrainCloudLobby self, String in_roomType, Int32 in_rating, Int32 in_maxSteps, Dictionary<String, Object> in_algo, Dictionary<String, Object> in_filterJson, Int32 in_timeoutSecs, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, Dictionary<String, Object> in_settings, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FindOrCreateLobbyWithPingData(
				in_roomType, in_rating, in_maxSteps, in_algo, in_filterJson, in_timeoutSecs, in_isReady, in_extraJson, in_teamCode, in_settings, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetLobbyDataAsync(this BrainCloudLobby self, String in_lobbyID)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetLobbyData(
				in_lobbyID,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateReadyAsync<T1, T2>(this BrainCloudLobby self, String in_lobbyID, Boolean in_isReady, Dictionary<String, Object> in_extraJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateReady(
				in_lobbyID, in_isReady, in_extraJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSettingsAsync<T1, T2>(this BrainCloudLobby self, String in_lobbyID, Dictionary<String, Object> in_settings)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSettings(
				in_lobbyID, in_settings,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SwitchTeamAsync(this BrainCloudLobby self, String in_lobbyID, String in_toTeamName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SwitchTeam(
				in_lobbyID, in_toTeamName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendSignalAsync<T1, T2>(this BrainCloudLobby self, String in_lobbyID, Dictionary<String, Object> in_signalData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendSignal(
				in_lobbyID, in_signalData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> JoinLobbyAsync<T1, T2>(this BrainCloudLobby self, String in_lobbyID, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.JoinLobby(
				in_lobbyID, in_isReady, in_extraJson, in_teamCode, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> JoinLobbyWithPingDataAsync<T1, T2>(this BrainCloudLobby self, String in_lobbyID, Boolean in_isReady, Dictionary<String, Object> in_extraJson, String in_teamCode, String[] in_otherUserCxIds)
		{
			var tcs = new TaskCompletionSource<String>();
			self.JoinLobbyWithPingData(
				in_lobbyID, in_isReady, in_extraJson, in_teamCode, in_otherUserCxIds,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> LeaveLobbyAsync(this BrainCloudLobby self, String in_lobbyID)
		{
			var tcs = new TaskCompletionSource<String>();
			self.LeaveLobby(
				in_lobbyID,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveMemberAsync(this BrainCloudLobby self, String in_lobbyID, String in_connectionId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveMember(
				in_lobbyID, in_connectionId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CancelFindRequestAsync(this BrainCloudLobby self, String in_roomType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CancelFindRequest(
				in_roomType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRegionsForLobbiesAsync(this BrainCloudLobby self, String[] in_roomTypes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRegionsForLobbies(
				in_roomTypes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PingRegionsAsync(this BrainCloudLobby self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PingRegions(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}