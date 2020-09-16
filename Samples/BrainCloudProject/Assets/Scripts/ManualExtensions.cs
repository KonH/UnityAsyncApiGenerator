using System;
using System.Threading.Tasks;
using BrainCloud;

namespace Scripts {
	public static class ManualExtensions {
		public static Task<string> AuthenticateUniversalAsync(
			this BrainCloudWrapper self,
			string username,
			string password,
			bool forceCreate) {
			throw new NotImplementedException();
		}

		public static Task<string> GetListByIndexedIdAsync(
			this BrainCloudGlobalEntity self,
			string entityIndexedId,
			int maxReturn) {
			throw new NotImplementedException();
		}

		public static Task<string> GetSingletonAsync(
			this BrainCloudEntity self,
			string entityType) {
			throw new NotImplementedException();
		}

		public static Task<string> CreateEntityWithIndexedIdAsync(
			this BrainCloudGlobalEntity self,
			string entityType,
			string indexedId,
			long timeToLive,
			string jsonEntityAcl,
			string jsonEntityData) {
			throw new NotImplementedException();
		}

		public static Task<string> UpdateSingletonAsync(
			this BrainCloudEntity self,
			string entityType,
			string jsonEntityData,
			string jsonEntityAcl,
			int version) {
			throw new NotImplementedException();
		}

		public static Task<string> UpdateEntityAsync(
			this BrainCloudGlobalEntity self,
			string entityId,
			int version,
			string jsonEntityData) {
			throw new NotImplementedException();
		}
	}
}