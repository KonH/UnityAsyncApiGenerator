using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudEntityExtensions
	{
		public static Task<String> CreateEntityAsync(this BrainCloudEntity self, String entityType, String jsonEntityData, String jsonEntityAcl)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateEntity(
				entityType, jsonEntityData, jsonEntityAcl,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEntitiesByTypeAsync(this BrainCloudEntity self, String entityType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEntitiesByType(
				entityType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityAsync(this BrainCloudEntity self, String entityId, String entityType, String jsonEntityData, String jsonEntityAcl, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntity(
				entityId, entityType, jsonEntityData, jsonEntityAcl, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSharedEntityAsync(this BrainCloudEntity self, String entityId, String targetProfileId, String entityType, String jsonEntityData, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSharedEntity(
				entityId, targetProfileId, entityType, jsonEntityData, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteEntityAsync(this BrainCloudEntity self, String entityId, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteEntity(
				entityId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSingletonAsync(this BrainCloudEntity self, String entityType, String jsonEntityData, String jsonEntityAcl, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSingleton(
				entityType, jsonEntityData, jsonEntityAcl, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteSingletonAsync(this BrainCloudEntity self, String entityType, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteSingleton(
				entityType, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEntityAsync(this BrainCloudEntity self, String entityId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEntity(
				entityId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSingletonAsync(this BrainCloudEntity self, String entityType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSingleton(
				entityType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSharedEntityForProfileIdAsync(this BrainCloudEntity self, String profileId, String entityId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSharedEntityForProfileId(
				profileId, entityId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSharedEntitiesForProfileIdAsync(this BrainCloudEntity self, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSharedEntitiesForProfileId(
				profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetListAsync(this BrainCloudEntity self, String whereJson, String orderByJson, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetList(
				whereJson, orderByJson, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSharedEntitiesListForProfileIdAsync(this BrainCloudEntity self, String profileId, String whereJson, String orderByJson, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSharedEntitiesListForProfileId(
				profileId, whereJson, orderByJson, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetListCountAsync(this BrainCloudEntity self, String whereJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetListCount(
				whereJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPageAsync(this BrainCloudEntity self, String jsonContext)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPage(
				jsonContext,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPageOffsetAsync(this BrainCloudEntity self, String context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPageOffset(
				context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementUserEntityDataAsync(this BrainCloudEntity self, String entityId, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementUserEntityData(
				entityId, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementSharedUserEntityDataAsync(this BrainCloudEntity self, String entityId, String targetProfileId, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementSharedUserEntityData(
				entityId, targetProfileId, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}