namespace Scripts {
	public sealed class EntityResponse {
		public sealed class Data {
			public string       entityId;
			public int          version;
			public SimpleEntity data;
		}

		public Data data;
		public int  status;
	}
}