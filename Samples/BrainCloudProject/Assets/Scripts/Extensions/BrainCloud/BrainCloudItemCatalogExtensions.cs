using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudItemCatalogExtensions
	{
		public static Task<String> GetCatalogItemDefinitionAsync(this BrainCloudItemCatalog self, String defId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCatalogItemDefinition(
				defId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetCatalogItemsPageAsync(this BrainCloudItemCatalog self, String context)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCatalogItemsPage(
				context,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetCatalogItemsPageOffsetAsync(this BrainCloudItemCatalog self, String context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCatalogItemsPageOffset(
				context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}