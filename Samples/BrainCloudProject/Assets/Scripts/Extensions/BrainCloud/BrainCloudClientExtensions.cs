using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudClientExtensions
	{
		public static Task<String> SendHeartbeatAsync(this BrainCloudClient self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendHeartbeat(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}