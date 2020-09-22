using System.Threading.Tasks;
using BrainCloud;
using System;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPlayerStateExtensions
	{
		public static Task<String> ReadUserStateAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadUserState(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeletePlayerAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeletePlayer(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteUserAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteUser(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUserAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUser(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> LogoutAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.Logout(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateUserNameAsync(this BrainCloudPlayerState self, String userName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateUserName(
				userName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateSummaryFriendDataAsync(this BrainCloudPlayerState self, String jsonSummaryData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateSummaryFriendData(
				jsonSummaryData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetAttributesAsync(this BrainCloudPlayerState self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetAttributes(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateAttributesAsync(this BrainCloudPlayerState self, String jsonAttributes, Boolean wipeExisting)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateAttributes(
				jsonAttributes, wipeExisting,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveAttributesAsync<T1>(this BrainCloudPlayerState self, IList<String> attributeNames)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveAttributes(
				attributeNames,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateUserPictureUrlAsync(this BrainCloudPlayerState self, String pictureUrl)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateUserPictureUrl(
				pictureUrl,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateContactEmailAsync(this BrainCloudPlayerState self, String contactEmail)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateContactEmail(
				contactEmail,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ClearUserStatusAsync(this BrainCloudPlayerState self, String statusName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ClearUserStatus(
				statusName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ExtendUserStatusAsync(this BrainCloudPlayerState self, String statusName, Int32 additionalSecs, String details)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ExtendUserStatus(
				statusName, additionalSecs, details,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetUserStatusAsync(this BrainCloudPlayerState self, String statusName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetUserStatus(
				statusName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SetUserStatusAsync(this BrainCloudPlayerState self, String statusName, Int32 durationSecs, String details)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SetUserStatus(
				statusName, durationSecs, details,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateLanguageCodeAsync(this BrainCloudPlayerState self, String languageCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateLanguageCode(
				languageCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateTimeZoneOffsetAsync(this BrainCloudPlayerState self, String timeZoneOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateTimeZoneOffset(
				timeZoneOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}