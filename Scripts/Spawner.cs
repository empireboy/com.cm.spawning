using System.Numerics;

namespace CM.Spawning
{
	public abstract class Spawner<T>
	{
		public Vector3 Position { get; set; }
		public bool SpawnOnLoad { get; private set; }

		public Spawner(Vector3 position, bool spawnOnLoad = false)
		{
			Position = position;
			SpawnOnLoad = spawnOnLoad;
		}

		public abstract T Spawn();

		protected virtual void OnLoad()
		{
			if (SpawnOnLoad)
				Spawn();
		}
	}
}