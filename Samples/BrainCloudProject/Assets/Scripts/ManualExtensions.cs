using System;
using System.Threading.Tasks;
using BrainCloud;

namespace Scripts {
	public static class ManualExtensions {
		public static Task<string> AuthenticateUniversalAsync(
			this BrainCloudWrapper self,
			string username,
			string password,
			bool forceCreate) {
			var tcs = new TaskCompletionSource<string>();
			self.AuthenticateUniversal(
				username, password, forceCreate,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<string> GetListByIndexedIdAsync(
			this BrainCloudGlobalEntity self,
			string entityIndexedId,
			int maxReturn) {
			var tcs = new TaskCompletionSource<string>();
			self.GetListByIndexedId(
				entityIndexedId, maxReturn,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<string> GetSingletonAsync(
			this BrainCloudEntity self,
			string entityType) {
			var tcs = new TaskCompletionSource<string>();
			self.GetSingleton(
				entityType,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<string> CreateEntityWithIndexedIdAsync(
			this BrainCloudGlobalEntity self,
			string entityType,
			string indexedId,
			long timeToLive,
			string jsonEntityAcl,
			string jsonEntityData) {
			var tcs = new TaskCompletionSource<string>();
			self.CreateEntityWithIndexedId(
				entityType, indexedId, timeToLive, jsonEntityAcl, jsonEntityData,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<string> UpdateSingletonAsync(
			this BrainCloudEntity self,
			string entityType,
			string jsonEntityData,
			string jsonEntityAcl,
			int version) {
			var tcs = new TaskCompletionSource<string>();
			self.UpdateSingleton(
				entityType, jsonEntityData, jsonEntityAcl, version,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<string> UpdateEntityAsync(
			this BrainCloudGlobalEntity self,
			string entityId,
			int version,
			string jsonEntityData) {
			var tcs = new TaskCompletionSource<string>();
			self.UpdateEntity(
				entityId, version, jsonEntityData,
				(response, _) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}