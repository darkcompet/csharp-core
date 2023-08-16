namespace Tool.Compet.Core {
	public class DkListDictionary<T> {
		private readonly List<string> list;
		private readonly Dictionary<string, T> map;

		public DkListDictionary(int capacity = 10) {
			this.list = new(capacity);
			this.map = new Dictionary<string, T>(capacity);
		}

		/// Define the indexer to allow client code to use [] notation.
		public T this[string key] {
			get { return this.map[key]; }
			set { this.map[key] = value; }
		}

		// public T this[int index] {
		// 	get { var key = this.list[index]; return this.map[key]; }
		// 	private set { }
		// }

		public T? GetValueOrDefault(string key) {
			return this.map.GetValueOrDefault(key);
		}

		public void Add(string key, T value) {
			this.map.Add(key, value);
			this.list.Add(key);
		}

		public bool TryAdd(string key, T value) {
			if (this.map.TryAdd(key, value)) {
				this.list.Add(key);
				return true;
			}
			return false;
		}

		public int Count => this.list.Count;
		// public long LongCount => this.keys.LongCount();

		public string[] Keys {
			get {
				var arr = new string[this.list.Count];
				for (var index = this.list.Count - 1; index >= 0; --index) {
					arr[index] = this.list[index];
				}
				return arr;
			}
			private set { }
		}
	}
}
