using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudRTTExtensions
	{
		public static Task<String> EnableRTTAsync(this BrainCloudRTT self, RTTConnectionType in_connectionType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.EnableRTT(
				in_connectionType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RequestClientConnectionAsync(this BrainCloudRTT self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RequestClientConnection(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}