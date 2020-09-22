using System.Threading.Tasks;
using BrainCloud.Entity;
using System;

namespace Scripts.Extensions.BrainCloud.Entity
{
	public static class BCEntityExtensions
	{
		public static Task<String> StoreAsyncAsync(this BCEntity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StoreAsync(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> StoreAsyncSharedAsync(this BCEntity self, String targetProfileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.StoreAsyncShared(
				targetProfileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteAsyncAsync(this BCEntity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteAsync(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}