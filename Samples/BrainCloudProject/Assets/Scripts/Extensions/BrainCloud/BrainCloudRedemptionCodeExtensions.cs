using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudRedemptionCodeExtensions
	{
		public static Task<String> RedeemCodeAsync(this BrainCloudRedemptionCode self, String scanCode, String codeType, String jsonCustomRedemptionInfo)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RedeemCode(
				scanCode, codeType, jsonCustomRedemptionInfo,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRedeemedCodesAsync(this BrainCloudRedemptionCode self, String codeType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRedeemedCodes(
				codeType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}