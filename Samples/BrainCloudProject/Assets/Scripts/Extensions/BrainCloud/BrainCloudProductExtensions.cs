using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudProductExtensions
	{
		public static Task<String> GetCurrencyAsync(this BrainCloudProduct self, String currencyType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCurrency(
				currencyType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSalesInventoryAsync(this BrainCloudProduct self, String platform, String userCurrency)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSalesInventory(
				platform, userCurrency,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetSalesInventoryByCategoryAsync(this BrainCloudProduct self, String platform, String userCurrency, String category)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetSalesInventoryByCategory(
				platform, userCurrency, category,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> StartSteamTransactionAsync(this BrainCloudProduct self, String language, String itemId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StartSteamTransaction(
				language, itemId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> FinalizeSteamTransactionAsync(this BrainCloudProduct self, String transId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.FinalizeSteamTransaction(
				transId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> VerifyMicrosoftReceiptAsync(this BrainCloudProduct self, String receipt)
		{
			var tcs = new TaskCompletionSource<String>();
			self.VerifyMicrosoftReceipt(
				receipt,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetEligiblePromotionsAsync(this BrainCloudProduct self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetEligiblePromotions(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> VerifyItunesReceiptAsync(this BrainCloudProduct self, String base64EncReceiptData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.VerifyItunesReceipt(
				base64EncReceiptData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ConfirmFacebookPurchaseAsync(this BrainCloudProduct self, String signedRequest)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ConfirmFacebookPurchase(
				signedRequest,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ConfirmGooglePlayPurchaseAsync(this BrainCloudProduct self, String orderId, String productId, String token)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ConfirmGooglePlayPurchase(
				orderId, productId, token,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AwardCurrencyAsync(this BrainCloudProduct self, String currencyType, UInt64 amount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AwardCurrency(
				currencyType, amount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ConsumeCurrencyAsync(this BrainCloudProduct self, String currencyType, UInt64 amount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ConsumeCurrency(
				currencyType, amount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetCurrencyAsync(this BrainCloudProduct self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetCurrency(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}