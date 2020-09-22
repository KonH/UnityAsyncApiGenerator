using System.Threading.Tasks;
using BrainCloud;
using System;
using BrainCloud.Common;

namespace Scripts.Extensions.BrainCloud
{
	public static class BrainCloudGroupExtensions
	{
		public static Task<String> AcceptGroupInvitationAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AcceptGroupInvitation(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AddGroupMemberAsync(this BrainCloudGroup self, String groupId, String profileId, BrainCloudGroup.Role role, String jsonAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AddGroupMember(
				groupId, profileId, role, jsonAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ApproveGroupJoinRequestAsync(this BrainCloudGroup self, String groupId, String profileId, BrainCloudGroup.Role role, String jsonAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ApproveGroupJoinRequest(
				groupId, profileId, role, jsonAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AutoJoinGroupAsync(this BrainCloudGroup self, String groupType, BrainCloudGroup.AutoJoinStrategy autoJoinStrategy, String dataQueryJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AutoJoinGroup(
				groupType, autoJoinStrategy, dataQueryJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> AutoJoinGroupMultiAsync(this BrainCloudGroup self, String[] groupTypes, BrainCloudGroup.AutoJoinStrategy autoJoinStrategy, String dataQueryJson)
		{
			var tcs = new TaskCompletionSource<String>();
			self.AutoJoinGroupMulti(
				groupTypes, autoJoinStrategy, dataQueryJson,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CancelGroupInvitationAsync(this BrainCloudGroup self, String groupId, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CancelGroupInvitation(
				groupId, profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateGroupAsync<T1>(this BrainCloudGroup self, String name, String groupType, Nullable<Boolean> isOpenGroup, GroupACL acl, String jsonData, String jsonOwnerAttributes, String jsonDefaultMemberAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateGroup(
				name, groupType, isOpenGroup, acl, jsonData, jsonOwnerAttributes, jsonDefaultMemberAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateGroupAsync<T1>(this BrainCloudGroup self, String name, String groupType, Nullable<Boolean> isOpenGroup, GroupACL acl, String jsonData, String jsonOwnerAttributes, String jsonDefaultMemberAttributes, String jsonSummaryData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateGroup(
				name, groupType, isOpenGroup, acl, jsonData, jsonOwnerAttributes, jsonDefaultMemberAttributes, jsonSummaryData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> CreateGroupEntityAsync<T1>(this BrainCloudGroup self, String groupId, String entityType, Nullable<Boolean> isOwnedByGroupMember, GroupACL acl, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.CreateGroupEntity(
				groupId, entityType, isOwnedByGroupMember, acl, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteGroupAsync(this BrainCloudGroup self, String groupId, Int64 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteGroup(
				groupId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> DeleteGroupEntityAsync(this BrainCloudGroup self, String groupId, String entityId, Int64 version)
		{
			var tcs = new TaskCompletionSource<String>();
			self.DeleteGroupEntity(
				groupId, entityId, version,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetMyGroupsAsync(this BrainCloudGroup self)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetMyGroups(
				
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementGroupDataAsync(this BrainCloudGroup self, String groupId, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementGroupData(
				groupId, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> IncrementGroupEntityDataAsync(this BrainCloudGroup self, String groupId, String entityId, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.IncrementGroupEntityData(
				groupId, entityId, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> InviteGroupMemberAsync(this BrainCloudGroup self, String groupId, String profileId, BrainCloudGroup.Role role, String jsonAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.InviteGroupMember(
				groupId, profileId, role, jsonAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> JoinGroupAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.JoinGroup(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> LeaveGroupAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.LeaveGroup(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListGroupsPageAsync(this BrainCloudGroup self, String jsonContext)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListGroupsPage(
				jsonContext,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListGroupsPageByOffsetAsync(this BrainCloudGroup self, String context, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListGroupsPageByOffset(
				context, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ListGroupsWithMemberAsync(this BrainCloudGroup self, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ListGroupsWithMember(
				profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroup(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupDataAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroupData(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupEntitiesPageAsync(this BrainCloudGroup self, String jsonContext)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroupEntitiesPage(
				jsonContext,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupEntitiesPageByOffsetAsync(this BrainCloudGroup self, String encodedContext, Int32 pageOffset)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroupEntitiesPageByOffset(
				encodedContext, pageOffset,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupEntityAsync(this BrainCloudGroup self, String groupId, String entityId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroupEntity(
				groupId, entityId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> ReadGroupMembersAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.ReadGroupMembers(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RejectGroupInvitationAsync(this BrainCloudGroup self, String groupId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RejectGroupInvitation(
				groupId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RejectGroupJoinRequestAsync(this BrainCloudGroup self, String groupId, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RejectGroupJoinRequest(
				groupId, profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> RemoveGroupMemberAsync(this BrainCloudGroup self, String groupId, String profileId)
		{
			var tcs = new TaskCompletionSource<String>();
			self.RemoveGroupMember(
				groupId, profileId,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateGroupDataAsync(this BrainCloudGroup self, String groupId, Int64 version, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateGroupData(
				groupId, version, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateGroupEntityDataAsync(this BrainCloudGroup self, String groupId, String entityId, Int64 version, String jsonData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateGroupEntityData(
				groupId, entityId, version, jsonData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateGroupMemberAsync<T1>(this BrainCloudGroup self, String groupId, String profileId, Nullable<BrainCloudGroup.Role> role, String jsonAttributes)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateGroupMember(
				groupId, profileId, role, jsonAttributes,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateGroupNameAsync(this BrainCloudGroup self, String groupId, String name)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateGroupName(
				groupId, name,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> SetGroupOpenAsync(this BrainCloudGroup self, String groupId, Boolean isOpenGroup)
		{
			var tcs = new TaskCompletionSource<String>();
			self.SetGroupOpen(
				groupId, isOpenGroup,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> UpdateGroupSummaryDataAsync(this BrainCloudGroup self, String groupId, Int32 version, String jsonSummaryData)
		{
			var tcs = new TaskCompletionSource<String>();
			self.UpdateGroupSummaryData(
				groupId, version, jsonSummaryData,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}

		public static Task<String> GetRandomGroupsMatchingAsync(this BrainCloudGroup self, String jsonWhere, Int32 maxReturn)
		{
			var tcs = new TaskCompletionSource<String>();
			self.GetRandomGroupsMatching(
				jsonWhere, maxReturn,
				(response, cbObject) => tcs.SetResult(response),
				(status, code, error, cbObject) => tcs.SetException(new Exception(error)));
			return tcs.Task;
		}
	}
}