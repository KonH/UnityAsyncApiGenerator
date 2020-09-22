using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudMailExtensions
	{
		public static Task<String> SendBasicEmailAsync(this BrainCloudMail self, String profileId, String subject, String body)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendBasicEmail(
				profileId, subject, body,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendAdvancedEmailAsync(this BrainCloudMail self, String profileId, String jsonServiceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendAdvancedEmail(
				profileId, jsonServiceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendAdvancedEmailByAddressAsync(this BrainCloudMail self, String emailAddress, String jsonServiceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendAdvancedEmailByAddress(
				emailAddress, jsonServiceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}