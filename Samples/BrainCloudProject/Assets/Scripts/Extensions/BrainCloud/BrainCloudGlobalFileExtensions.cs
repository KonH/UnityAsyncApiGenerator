using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGlobalFileExtensions
	{
		public static Task<String> GetFileInfoAsync(this BrainCloudGlobalFile self, String fileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetFileInfo(
				fileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetFileInfoSimpleAsync(this BrainCloudGlobalFile self, String folderPath, String filename)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetFileInfoSimple(
				folderPath, filename,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalCDNUrlAsync(this BrainCloudGlobalFile self, String fileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalCDNUrl(
				fileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetGlobalFileListAsync(this BrainCloudGlobalFile self, String folderPath, Boolean recurse)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetGlobalFileList(
				folderPath, recurse,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}