using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudTimeExtensions
	{
		public static Task<String> ReadServerTimeAsync(this BrainCloudTime self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadServerTime(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}