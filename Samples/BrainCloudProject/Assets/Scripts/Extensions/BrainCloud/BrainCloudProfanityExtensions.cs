using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudProfanityExtensions
	{
		public static Task<String> ProfanityCheckAsync(this BrainCloudProfanity self, String text, String languages, Boolean flagEmail, Boolean flagPhone, Boolean flagUrls)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProfanityCheck(
				text, languages, flagEmail, flagPhone, flagUrls,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProfanityReplaceTextAsync(this BrainCloudProfanity self, String text, String replaceSymbol, String languages, Boolean flagEmail, Boolean flagPhone, Boolean flagUrls)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProfanityReplaceText(
				text, replaceSymbol, languages, flagEmail, flagPhone, flagUrls,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ProfanityIdentifyBadWordsAsync(this BrainCloudProfanity self, String text, String languages, Boolean flagEmail, Boolean flagPhone, Boolean flagUrls)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ProfanityIdentifyBadWords(
				text, languages, flagEmail, flagPhone, flagUrls,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}