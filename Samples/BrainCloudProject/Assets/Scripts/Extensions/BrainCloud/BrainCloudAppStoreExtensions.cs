using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudAppStoreExtensions
	{
		public static Task<String> GetSalesInventoryAsync(this BrainCloudAppStore self, String platform, String userCurrency)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSalesInventory(
				platform, userCurrency,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSalesInventoryByCategoryAsync(this BrainCloudAppStore self, String storeId, String userCurrency, String category)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSalesInventoryByCategory(
				storeId, userCurrency, category,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEligiblePromotionsAsync(this BrainCloudAppStore self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEligiblePromotions(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> VerifyPurchaseAsync(this BrainCloudAppStore self, String storeId, String receiptJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.VerifyPurchase(
				storeId, receiptJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> StartPurchaseAsync(this BrainCloudAppStore self, String storeId, String purchaseJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StartPurchase(
				storeId, purchaseJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FinalizePurchaseAsync(this BrainCloudAppStore self, String storeId, String transactionId, String transactionJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FinalizePurchase(
				storeId, transactionId, transactionJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}