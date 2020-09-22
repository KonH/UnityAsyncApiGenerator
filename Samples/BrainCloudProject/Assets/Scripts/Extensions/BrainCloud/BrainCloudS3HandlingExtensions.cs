using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudS3HandlingExtensions
	{
		public static Task<String> GetUpdatedFilesAsync(this BrainCloudS3Handling self, String category, String fileDetailsJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUpdatedFiles(
				category, fileDetailsJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetFileListAsync(this BrainCloudS3Handling self, String category)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetFileList(
				category,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetCDNUrlAsync(this BrainCloudS3Handling self, String fileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetCDNUrl(
				fileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}