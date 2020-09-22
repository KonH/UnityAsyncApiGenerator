using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudFileExtensions
	{
		public static Task<String> ListUserFilesAsync(this BrainCloudFile self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListUserFiles(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListUserFilesAsync<T1>(this BrainCloudFile self, String cloudPath, Nullable<Boolean> recurse)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListUserFiles(
				cloudPath, recurse,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteUserFileAsync(this BrainCloudFile self, String cloudPath, String cloudFileName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteUserFile(
				cloudPath, cloudFileName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteUserFilesAsync(this BrainCloudFile self, String cloudPath, Boolean recurse)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteUserFiles(
				cloudPath, recurse,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetCDNUrlAsync(this BrainCloudFile self, String cloudPath, String cloudFilename)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCDNUrl(
				cloudPath, cloudFilename,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}