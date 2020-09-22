using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGlobalAppExtensions
	{
		public static Task<String> ReadPropertiesAsync(this BrainCloudGlobalApp self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadProperties(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}