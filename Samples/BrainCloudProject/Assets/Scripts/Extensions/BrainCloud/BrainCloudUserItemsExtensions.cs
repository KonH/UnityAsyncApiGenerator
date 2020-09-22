using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudUserItemsExtensions
	{
		public static Task<String> AwardUserItemAsync(this BrainCloudUserItems self, String defId, Int32 quantity, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AwardUserItem(
				defId, quantity, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DropUserItemAsync(this BrainCloudUserItems self, String itemId, Int32 quantity, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DropUserItem(
				itemId, quantity, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetUserItemsPageAsync(this BrainCloudUserItems self, String context, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUserItemsPage(
				context, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetUserItemsPageOffsetAsync(this BrainCloudUserItems self, String context, Int32 pageOffset, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUserItemsPageOffset(
				context, pageOffset, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetUserItemAsync(this BrainCloudUserItems self, String itemId, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUserItem(
				itemId, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GiveUserItemToAsync(this BrainCloudUserItems self, String profileId, String itemId, Int32 version, Int32 quantity, Boolean immediate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GiveUserItemTo(
				profileId, itemId, version, quantity, immediate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PurchaseUserItemAsync(this BrainCloudUserItems self, String defId, Int32 quantity, String shopId, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PurchaseUserItem(
				defId, quantity, shopId, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReceiveUserItemFromAsync(this BrainCloudUserItems self, String profileId, String itemId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReceiveUserItemFrom(
				profileId, itemId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SellUserItemAsync(this BrainCloudUserItems self, String itemId, Int32 version, Int32 quantity, String shopId, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SellUserItem(
				itemId, version, quantity, shopId, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateUserItemDataAsync(this BrainCloudUserItems self, String itemId, Int32 version, String newItemData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateUserItemData(
				itemId, version, newItemData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UseUserItemAsync(this BrainCloudUserItems self, String itemId, Int32 version, String newItemData, Boolean includeDef)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UseUserItem(
				itemId, version, newItemData, includeDef,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> PublishUserItemToBlockchainAsync(this BrainCloudUserItems self, String itemId, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.PublishUserItemToBlockchain(
				itemId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RefreshBlockchainUserItemsAsync(this BrainCloudUserItems self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RefreshBlockchainUserItems(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveUserItemFromBlockchainAsync(this BrainCloudUserItems self, String itemId, Int32 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveUserItemFromBlockchain(
				itemId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}