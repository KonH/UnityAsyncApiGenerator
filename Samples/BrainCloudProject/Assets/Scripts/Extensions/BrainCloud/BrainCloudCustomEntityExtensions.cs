using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudCustomEntityExtensions
	{
		public static Task<String> CreateEntityAsync(this BrainCloudCustomEntity self, String entityType, String dataJson, String acl, String timeToLive, Boolean isOwned)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateEntity(
				entityType, dataJson, acl, timeToLive, isOwned,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEntityPageAsync(this BrainCloudCustomEntity self, String entityType, Int32 rowsPerPage, String searchJson, String sortJson, Boolean doCount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEntityPage(
				entityType, rowsPerPage, searchJson, sortJson, doCount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEntityPageAsync(this BrainCloudCustomEntity self, String entityType, String jsonContext)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEntityPage(
				entityType, jsonContext,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEntityPageOffsetAsync(this BrainCloudCustomEntity self, String entityType, String context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEntityPageOffset(
				entityType, context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadEntityAsync(this BrainCloudCustomEntity self, String entityType, String entityId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadEntity(
				entityType, entityId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementDataAsync(this BrainCloudCustomEntity self, String entityType, String entityId, String fieldsJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementData(
				entityType, entityId, fieldsJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityAsync(this BrainCloudCustomEntity self, String entityType, String entityId, Int32 version, String dataJson, String acl, String timeToLive)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntity(
				entityType, entityId, version, dataJson, acl, timeToLive,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateEntityFieldsAsync(this BrainCloudCustomEntity self, String entityType, String entityId, Int32 version, String fieldsJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateEntityFields(
				entityType, entityId, version, fieldsJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteEntitiesAsync(this BrainCloudCustomEntity self, String entityType, String deleteCriteria)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteEntities(
				entityType, deleteCriteria,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetCountAsync(this BrainCloudCustomEntity self, String entityType, String whereJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCount(
				entityType, whereJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteEntityAsync(this BrainCloudCustomEntity self, String entityType, String entityId, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteEntity(
				entityType, entityId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteSingletonAsync(this BrainCloudCustomEntity self, String entityType, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteSingleton(
				entityType, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadSingletonAsync(this BrainCloudCustomEntity self, String entityType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadSingleton(
				entityType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSingletonFieldsAsync(this BrainCloudCustomEntity self, String entityType, Int32 version, String fieldsJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSingletonFields(
				entityType, version, fieldsJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSingletonAsync(this BrainCloudCustomEntity self, String entityType, Int32 version, String dataJson, String acl, String timeToLive)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSingleton(
				entityType, version, dataJson, acl, timeToLive,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}