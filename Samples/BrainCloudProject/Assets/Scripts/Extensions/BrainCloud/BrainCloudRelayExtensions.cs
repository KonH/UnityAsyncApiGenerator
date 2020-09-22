using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudRelayExtensions
	{
		public static Task<String> ConnectAsync(this BrainCloudRelay self, RelayConnectionType in_connectionType, RelayConnectOptions in_options)
		{
			var tcs = new TaskCompletionSource<String>();
			self.Connect(
				in_connectionType, in_options,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}