using System.Threading.Tasks;
using BrainCloud;
using System;
using BrainCloud.Common;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudIdentityExtensions
	{
		public static Task<String> AttachFacebookIdentityAsync(this BrainCloudIdentity self, String facebookId, String authenticationToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachFacebookIdentity(
				facebookId, authenticationToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeFacebookIdentityAsync(this BrainCloudIdentity self, String facebookId, String authenticationToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeFacebookIdentity(
				facebookId, authenticationToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachFacebookIdentityAsync(this BrainCloudIdentity self, String facebookId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachFacebookIdentity(
				facebookId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachGameCenterIdentityAsync(this BrainCloudIdentity self, String gameCenterId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachGameCenterIdentity(
				gameCenterId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeGameCenterIdentityAsync(this BrainCloudIdentity self, String gameCenterId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeGameCenterIdentity(
				gameCenterId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachGameCenterIdentityAsync(this BrainCloudIdentity self, String gameCenterId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachGameCenterIdentity(
				gameCenterId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachEmailIdentityAsync(this BrainCloudIdentity self, String email, String password)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachEmailIdentity(
				email, password,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeEmailIdentityAsync(this BrainCloudIdentity self, String email, String password)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeEmailIdentity(
				email, password,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachEmailIdentityAsync(this BrainCloudIdentity self, String email, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachEmailIdentity(
				email, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachUniversalIdentityAsync(this BrainCloudIdentity self, String userId, String password)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachUniversalIdentity(
				userId, password,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeUniversalIdentityAsync(this BrainCloudIdentity self, String userId, String password)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeUniversalIdentity(
				userId, password,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachUniversalIdentityAsync(this BrainCloudIdentity self, String userId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachUniversalIdentity(
				userId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachSteamIdentityAsync(this BrainCloudIdentity self, String steamId, String sessionTicket)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachSteamIdentity(
				steamId, sessionTicket,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeSteamIdentityAsync(this BrainCloudIdentity self, String steamId, String sessionTicket)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeSteamIdentity(
				steamId, sessionTicket,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachSteamIdentityAsync(this BrainCloudIdentity self, String steamId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachSteamIdentity(
				steamId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachGoogleIdentityAsync(this BrainCloudIdentity self, String googleUserId, String serverAuthCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachGoogleIdentity(
				googleUserId, serverAuthCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeGoogleIdentityAsync(this BrainCloudIdentity self, String googleUserId, String serverAuthCode)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeGoogleIdentity(
				googleUserId, serverAuthCode,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachGoogleIdentityAsync(this BrainCloudIdentity self, String googleUserId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachGoogleIdentity(
				googleUserId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachGoogleOpenIdIdentityAsync(this BrainCloudIdentity self, String googleUserAccountEmail, String IdToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachGoogleOpenIdIdentity(
				googleUserAccountEmail, IdToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeGoogleOpenIdIdentityAsync(this BrainCloudIdentity self, String googleUserAccountEmail, String IdToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeGoogleOpenIdIdentity(
				googleUserAccountEmail, IdToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachGoogleOpenIdIdentityAsync(this BrainCloudIdentity self, String googleUserAccountEmail, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachGoogleOpenIdIdentity(
				googleUserAccountEmail, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachAppleIdentityAsync(this BrainCloudIdentity self, String appleUserId, String identityToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachAppleIdentity(
				appleUserId, identityToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeAppleIdentityAsync(this BrainCloudIdentity self, String appleUserId, String identityToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeAppleIdentity(
				appleUserId, identityToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachAppleIdentityAsync(this BrainCloudIdentity self, String appleUserId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachAppleIdentity(
				appleUserId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachTwitterIdentityAsync(this BrainCloudIdentity self, String twitterId, String authenticationToken, String secret)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachTwitterIdentity(
				twitterId, authenticationToken, secret,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeTwitterIdentityAsync(this BrainCloudIdentity self, String twitterId, String authenticationToken, String secret)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeTwitterIdentity(
				twitterId, authenticationToken, secret,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachTwitterIdentityAsync(this BrainCloudIdentity self, String twitterId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachTwitterIdentity(
				twitterId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachParseIdentityAsync(this BrainCloudIdentity self, String parseId, String authenticationToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachParseIdentity(
				parseId, authenticationToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> MergeParseIdentityAsync(this BrainCloudIdentity self, String parseId, String authenticationToken)
		{
			var tcs = new TaskCompletionSource<String>();
			self.MergeParseIdentity(
				parseId, authenticationToken,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachParseIdentityAsync(this BrainCloudIdentity self, String parseId, Boolean continueAnon)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachParseIdentity(
				parseId, continueAnon,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SwitchToChildProfileAsync(this BrainCloudIdentity self, String childProfileId, String childAppId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SwitchToChildProfile(
				childProfileId, childAppId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SwitchToSingletonChildProfileAsync(this BrainCloudIdentity self, String childAppId, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SwitchToSingletonChildProfile(
				childAppId, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachNonLoginUniversalIdAsync(this BrainCloudIdentity self, String externalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachNonLoginUniversalId(
				externalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateUniversalIdLoginAsync(this BrainCloudIdentity self, String externalId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateUniversalIdLogin(
				externalId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachParentWithIdentityAsync(this BrainCloudIdentity self, String externalId, String authenticationToken, AuthenticationType authenticationType, String externalAuthName, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachParentWithIdentity(
				externalId, authenticationToken, authenticationType, externalAuthName, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SwitchToParentProfileAsync(this BrainCloudIdentity self, String parentLevelName)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SwitchToParentProfile(
				parentLevelName,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachParentAsync(this BrainCloudIdentity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachParent(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetChildProfilesAsync(this BrainCloudIdentity self, Boolean includeSummaryData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetChildProfiles(
				includeSummaryData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetIdentitiesAsync(this BrainCloudIdentity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetIdentities(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetExpiredIdentitiesAsync(this BrainCloudIdentity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetExpiredIdentities(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RefreshIdentityAsync(this BrainCloudIdentity self, String externalId, String authenticationToken, AuthenticationType authenticationType)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RefreshIdentity(
				externalId, authenticationToken, authenticationType,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ChangeEmailIdentityAsync(this BrainCloudIdentity self, String oldEmailAddress, String password, String newEmailAddress, Boolean updateContactEmail)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ChangeEmailIdentity(
				oldEmailAddress, password, newEmailAddress, updateContactEmail,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachPeerProfileAsync(this BrainCloudIdentity self, String peer, String externalId, String authenticationToken, AuthenticationType authenticationType, String externalAuthName, Boolean forceCreate)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachPeerProfile(
				peer, externalId, authenticationToken, authenticationType, externalAuthName, forceCreate,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachPeerAsync(this BrainCloudIdentity self, String peer)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachPeer(
				peer,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetPeerProfilesAsync(this BrainCloudIdentity self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetPeerProfiles(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AttachBlockChainAsync(this BrainCloudIdentity self, String blockchainConfig, String publicKey)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AttachBlockChain(
				blockchainConfig, publicKey,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DetachBlockChainAsync(this BrainCloudIdentity self, String blockchainConfig)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DetachBlockChain(
				blockchainConfig,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}