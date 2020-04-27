using System.Numerics;

namespace CM.Spawning
{
	public abstract class SingleObjectSpawner<T> : Spawner<T>
	{
		protected T spawnableObject;

		public SingleObjectSpawner(T spawnableObject, Vector3 position, bool spawnOnLoad = false) : base(position, spawnOnLoad)
		{
			this.spawnableObject = spawnableObject;
		}

		public abstract T OnSpawn(T spawnableObject);

		public override T Spawn()
		{
			return OnSpawn(spawnableObject);
		}
	}
}