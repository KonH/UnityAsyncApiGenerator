using System.Threading.Tasks;
using BrainCloud;
using System;
using BrainCloud.Common;
using System.Collections.Generic;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudPushNotificationExtensions
	{
		public static Task<String> DeregisterAllPushNotificationDeviceTokensAsync(this BrainCloudPushNotification self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeregisterAllPushNotificationDeviceTokens(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeregisterPushNotificationDeviceTokenAsync(this BrainCloudPushNotification self, Platform platform, String token)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeregisterPushNotificationDeviceToken(
				platform, token,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RegisterPushNotificationDeviceTokenAsync(this BrainCloudPushNotification self, Platform platform, String token)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RegisterPushNotificationDeviceToken(
				platform, token,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendSimplePushNotificationAsync(this BrainCloudPushNotification self, String toProfileId, String message)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendSimplePushNotification(
				toProfileId, message,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendRichPushNotificationAsync(this BrainCloudPushNotification self, String toProfileId, Int32 notificationTemplateId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendRichPushNotification(
				toProfileId, notificationTemplateId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendRichPushNotificationWithParamsAsync(this BrainCloudPushNotification self, String toProfileId, Int32 notificationTemplateId, String substitutionJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendRichPushNotificationWithParams(
				toProfileId, notificationTemplateId, substitutionJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendTemplatedPushNotificationToGroupAsync(this BrainCloudPushNotification self, String groupId, Int32 notificationTemplateId, String substitutionsJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendTemplatedPushNotificationToGroup(
				groupId, notificationTemplateId, substitutionsJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendNormalizedPushNotificationToGroupAsync(this BrainCloudPushNotification self, String groupId, String alertContentJson, String customDataJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendNormalizedPushNotificationToGroup(
				groupId, alertContentJson, customDataJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRawPushNotificationUTCAsync(this BrainCloudPushNotification self, String profileId, String fcmContent, String iosContent, String facebookContent, UInt64 startTimeUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRawPushNotificationUTC(
				profileId, fcmContent, iosContent, facebookContent, startTimeUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRawPushNotificationMinutesAsync(this BrainCloudPushNotification self, String profileId, String fcmContent, String iosContent, String facebookContent, Int32 minutesFromNow)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRawPushNotificationMinutes(
				profileId, fcmContent, iosContent, facebookContent, minutesFromNow,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendRawPushNotificationAsync(this BrainCloudPushNotification self, String toProfileId, String fcmContent, String iosContent, String facebookContent)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendRawPushNotification(
				toProfileId, fcmContent, iosContent, facebookContent,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendRawPushNotificationBatchAsync<T1>(this BrainCloudPushNotification self, IList<String> profileIds, String fcmContent, String iosContent, String facebookContent)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendRawPushNotificationBatch(
				profileIds, fcmContent, iosContent, facebookContent,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendRawPushNotificationToGroupAsync(this BrainCloudPushNotification self, String groupId, String fcmContent, String iosContent, String facebookContent)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendRawPushNotificationToGroup(
				groupId, fcmContent, iosContent, facebookContent,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleNormalizedPushNotificationUTCAsync(this BrainCloudPushNotification self, String profileId, String alertContentJson, String customDataJson, UInt64 startTimeUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleNormalizedPushNotificationUTC(
				profileId, alertContentJson, customDataJson, startTimeUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleNormalizedPushNotificationMinutesAsync(this BrainCloudPushNotification self, String profileId, String alertContentJson, String customDataJson, Int32 minutesFromNow)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleNormalizedPushNotificationMinutes(
				profileId, alertContentJson, customDataJson, minutesFromNow,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRichPushNotificationUTCAsync(this BrainCloudPushNotification self, String profileId, Int32 notificationTemplateId, String substitutionsJson, UInt64 startTimeUTC)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRichPushNotificationUTC(
				profileId, notificationTemplateId, substitutionsJson, startTimeUTC,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ScheduleRichPushNotificationMinutesAsync(this BrainCloudPushNotification self, String profileId, Int32 notificationTemplateId, String substitutionsJson, Int32 minutesFromNow)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ScheduleRichPushNotificationMinutes(
				profileId, notificationTemplateId, substitutionsJson, minutesFromNow,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendNormalizedPushNotificationAsync(this BrainCloudPushNotification self, String toProfileId, String alertContentJson, String customDataJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendNormalizedPushNotification(
				toProfileId, alertContentJson, customDataJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SendNormalizedPushNotificationBatchAsync<T1>(this BrainCloudPushNotification self, IList<String> profileIds, String alertContentJson, String customDataJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SendNormalizedPushNotificationBatch(
				profileIds, alertContentJson, customDataJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}