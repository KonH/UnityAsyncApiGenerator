using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudVirtualCurrencyExtensions
	{
		public static Task<String> GetCurrencyAsync(this BrainCloudVirtualCurrency self, String currencyType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCurrency(
				currencyType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetParentCurrencyAsync(this BrainCloudVirtualCurrency self, String currencyType, String levelName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetParentCurrency(
				currencyType, levelName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPeerCurrencyAsync(this BrainCloudVirtualCurrency self, String currencyType, String peerCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPeerCurrency(
				currencyType, peerCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetCurrencyAsync(this BrainCloudVirtualCurrency self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetCurrency(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AwardCurrencyAsync(this BrainCloudVirtualCurrency self, String currencyType, UInt64 amount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AwardCurrency(
				currencyType, amount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ConsumeCurrencyAsync(this BrainCloudVirtualCurrency self, String currencyType, UInt64 amount)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ConsumeCurrency(
				currencyType, amount,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}