using System.Threading.Tasks;
using BrainCloud;
using System;
using BrainCloud.Common;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGlobalEntityExtensions
	{
		public static Task<String> CreateEntityAsync(this BrainCloudGlobalEntity self, String entityType, Int64 timeToLive, String jsonEntityAcl, String jsonEntityData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateEntity(
				entityType, timeToLive, jsonEntityAcl, jsonEntityData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateEntityWithIndexedIdAsync(this BrainCloudGlobalEntity self, String entityType, String indexedId, Int64 timeToLive, String jsonEntityAcl, String jsonEntityData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateEntityWithIndexedId(
				entityType, indexedId, timeToLive, jsonEntityAcl, jsonEntityData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityAsync(this BrainCloudGlobalEntity self, String entityId, Int32 version, String jsonEntityData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntity(
				entityId, version, jsonEntityData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityAclAsync(this BrainCloudGlobalEntity self, String entityId, Int32 version, String jsonEntityAcl)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntityAcl(
				entityId, version, jsonEntityAcl,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityTimeToLiveAsync(this BrainCloudGlobalEntity self, String entityId, Int32 version, Int64 timeToLive)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntityTimeToLive(
				entityId, version, timeToLive,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteEntityAsync(this BrainCloudGlobalEntity self, String entityId, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteEntity(
				entityId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadEntityAsync(this BrainCloudGlobalEntity self, String entityId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadEntity(
				entityId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetListAsync(this BrainCloudGlobalEntity self, String whereJson, String orderByJson, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetList(
				whereJson, orderByJson, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetListByIndexedIdAsync(this BrainCloudGlobalEntity self, String entityIndexedId, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetListByIndexedId(
				entityIndexedId, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetListCountAsync(this BrainCloudGlobalEntity self, String whereJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetListCount(
				whereJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPageAsync(this BrainCloudGlobalEntity self, String jsonContext)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPage(
				jsonContext,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPageOffsetAsync(this BrainCloudGlobalEntity self, String context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPageOffset(
				context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementGlobalEntityDataAsync(this BrainCloudGlobalEntity self, String entityId, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementGlobalEntityData(
				entityId, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRandomEntitiesMatchingAsync(this BrainCloudGlobalEntity self, String whereJson, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRandomEntitiesMatching(
				whereJson, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityIndexedIdAsync(this BrainCloudGlobalEntity self, String entityId, Int64 version, String entityIndexedId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntityIndexedId(
				entityId, version, entityIndexedId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityOwnerAndAclAsync(this BrainCloudGlobalEntity self, String entityId, Int64 version, String ownerId, ACL acl)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntityOwnerAndAcl(
				entityId, version, ownerId, acl,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MakeSystemEntityAsync(this BrainCloudGlobalEntity self, String entityId, Int64 version, ACL acl)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MakeSystemEntity(
				entityId, version, acl,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}