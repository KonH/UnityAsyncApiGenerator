using System.Threading.Tasks;
using System;

namespace Scripts.Extensions
{
	public static class BrainCloudWrapperExtensions
	{
		public static Task<String> AuthenticateAnonymousAsync(this BrainCloudWrapper self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateAnonymous(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateHandoffAsync(this BrainCloudWrapper self, String handoffId, String securityToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateHandoff(
				handoffId, securityToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateSettopHandoffAsync(this BrainCloudWrapper self, String handoffCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateSettopHandoff(
				handoffCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateEmailPasswordAsync(this BrainCloudWrapper self, String email, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateEmailPassword(
				email, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateExternalAsync(this BrainCloudWrapper self, String userid, String token, String externalAuthName, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateExternal(
				userid, token, externalAuthName, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateFacebookAsync(this BrainCloudWrapper self, String fbUserId, String fbAuthToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateFacebook(
				fbUserId, fbAuthToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGameCenterAsync(this BrainCloudWrapper self, String gameCenterId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGameCenter(
				gameCenterId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateAppleAsync(this BrainCloudWrapper self, String appleUserId, String identityToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateApple(
				appleUserId, identityToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGoogleAsync(this BrainCloudWrapper self, String googleUserId, String serverAuthCode, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGoogle(
				googleUserId, serverAuthCode, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGoogleOpenIdAsync(this BrainCloudWrapper self, String googleUserAccountEmail, String IdToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGoogleOpenId(
				googleUserAccountEmail, IdToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateSteamAsync(this BrainCloudWrapper self, String userid, String sessionticket, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateSteam(
				userid, sessionticket, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateTwitterAsync(this BrainCloudWrapper self, String userid, String token, String secret, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateTwitter(
				userid, token, secret, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateUniversalAsync(this BrainCloudWrapper self, String username, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateUniversal(
				username, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateEmailAsync(this BrainCloudWrapper self, String email, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateEmail(
				email, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateExternalAsync(this BrainCloudWrapper self, String userid, String token, String externalAuthName, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateExternal(
				userid, token, externalAuthName, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateFacebookAsync(this BrainCloudWrapper self, String fbUserId, String fbAuthToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateFacebook(
				fbUserId, fbAuthToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateAppleAsync(this BrainCloudWrapper self, String appleUserId, String appleAuthToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateApple(
				appleUserId, appleAuthToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateGameCenterAsync(this BrainCloudWrapper self, String gameCenterId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateGameCenter(
				gameCenterId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateGoogleAsync(this BrainCloudWrapper self, String userid, String token, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateGoogle(
				userid, token, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateGoogleOpenIdAsync(this BrainCloudWrapper self, String userid, String token, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateGoogleOpenId(
				userid, token, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateSteamAsync(this BrainCloudWrapper self, String userid, String sessionticket, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateSteam(
				userid, sessionticket, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateTwitterAsync(this BrainCloudWrapper self, String userid, String token, String secret, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateTwitter(
				userid, token, secret, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SmartSwitchAuthenticateUniversalAsync(this BrainCloudWrapper self, String username, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SmartSwitchAuthenticateUniversal(
				username, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReconnectAsync(this BrainCloudWrapper self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.Reconnect(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAsync(this BrainCloudWrapper self, String externalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPassword(
				externalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAdvancedAsync(this BrainCloudWrapper self, String emailAddress, String serviceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordAdvanced(
				emailAddress, serviceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordWithExpiryAsync(this BrainCloudWrapper self, String externalId, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordWithExpiry(
				externalId, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAdvancedWithExpiryAsync(this BrainCloudWrapper self, String emailAddress, String serviceParams, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordAdvancedWithExpiry(
				emailAddress, serviceParams, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAsync(this BrainCloudWrapper self, String externalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPassword(
				externalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAdvancedAsync(this BrainCloudWrapper self, String emailAddress, String serviceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordAdvanced(
				emailAddress, serviceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordWithExpiryAsync(this BrainCloudWrapper self, String externalId, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordWithExpiry(
				externalId, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAdvancedWithExpiryAsync(this BrainCloudWrapper self, String emailAddress, String serviceParams, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordAdvancedWithExpiry(
				emailAddress, serviceParams, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}