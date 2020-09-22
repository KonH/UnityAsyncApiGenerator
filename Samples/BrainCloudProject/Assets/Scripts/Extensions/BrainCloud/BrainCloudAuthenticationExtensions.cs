using System.Threading.Tasks;
using BrainCloud;
using System;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudAuthenticationExtensions
	{
		public static Task<String> AuthenticateAnonymousAsync(this BrainCloudAuthentication self, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateAnonymous(
				forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateAnonymousAsync(this BrainCloudAuthentication self, String anonymousId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateAnonymous(
				anonymousId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateEmailPasswordAsync(this BrainCloudAuthentication self, String email, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateEmailPassword(
				email, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateUniversalAsync(this BrainCloudAuthentication self, String userId, String password, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateUniversal(
				userId, password, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateFacebookAsync(this BrainCloudAuthentication self, String externalId, String authenticationToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateFacebook(
				externalId, authenticationToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGameCenterAsync(this BrainCloudAuthentication self, String gameCenterId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGameCenter(
				gameCenterId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateSteamAsync(this BrainCloudAuthentication self, String userId, String sessionticket, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateSteam(
				userId, sessionticket, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateAppleAsync(this BrainCloudAuthentication self, String appleUserId, String identityToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateApple(
				appleUserId, identityToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGoogleAsync(this BrainCloudAuthentication self, String googleUserId, String serverAuthCode, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGoogle(
				googleUserId, serverAuthCode, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateGoogleOpenIdAsync(this BrainCloudAuthentication self, String googleUserAccountEmail, String IdToken, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateGoogleOpenId(
				googleUserAccountEmail, IdToken, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateTwitterAsync(this BrainCloudAuthentication self, String userId, String token, String secret, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateTwitter(
				userId, token, secret, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateParseAsync(this BrainCloudAuthentication self, String userId, String token, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateParse(
				userId, token, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateSettopHandoffAsync(this BrainCloudAuthentication self, String handoffCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateSettopHandoff(
				handoffCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateHandoffAsync(this BrainCloudAuthentication self, String handoffId, String securityToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateHandoff(
				handoffId, securityToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AuthenticateExternalAsync(this BrainCloudAuthentication self, String userId, String token, String externalAuthName, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AuthenticateExternal(
				userId, token, externalAuthName, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAsync(this BrainCloudAuthentication self, String externalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPassword(
				externalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordWithExpiryAsync(this BrainCloudAuthentication self, String externalId, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordWithExpiry(
				externalId, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAdvancedAsync(this BrainCloudAuthentication self, String emailAddress, String serviceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordAdvanced(
				emailAddress, serviceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetEmailPasswordAdvancedWithExpiryAsync(this BrainCloudAuthentication self, String emailAddress, String serviceParams, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetEmailPasswordAdvancedWithExpiry(
				emailAddress, serviceParams, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAsync(this BrainCloudAuthentication self, String universalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPassword(
				universalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordWithExpiryAsync(this BrainCloudAuthentication self, String universalId, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordWithExpiry(
				universalId, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAdvancedAsync(this BrainCloudAuthentication self, String universalId, String serviceParams)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordAdvanced(
				universalId, serviceParams,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ResetUniversalIdPasswordAdvancedWithExpiryAsync(this BrainCloudAuthentication self, String universalId, String serviceParams, Int32 tokenTtlInMinutes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ResetUniversalIdPasswordAdvancedWithExpiry(
				universalId, serviceParams, tokenTtlInMinutes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}