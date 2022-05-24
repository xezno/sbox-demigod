namespace Demigod;

public class ProceduralWorldGenerator
{
	private const int TILES_X = 32;
	private const int TILES_Y = 32;

	private const float TILE_WIDTH = 64f;
	private const float TILE_HEIGHT = 64f;

	/*
	 * Details/notes:
	 * - Sea level should always be 32 units
	 * - Generate spawnable resources - these can be picked up, thrown, used, interacted with
	 * - Terrain thru perlin noise
	 */
	public void Generate()
	{
		int halfTilesX = TILES_X / 2;
		int halfTilesY = TILES_Y / 2;

		var resources = ResourceLibrary.GetAll<WorldSpawnableResource>().ToList();

		// Generate tiles centered at world origin
		for ( int x = -halfTilesX; x < halfTilesX; x++ )
		{
			for ( int y = -halfTilesY; y < halfTilesY; y++ )
			{
				var tile = new Tile();
				tile.Position = new Vector3(
					x * TILE_WIDTH,
					y * TILE_HEIGHT
				);

				var resource = Rand.FromList( resources );
				if ( Rand.Float( 0, 1 ) < resource.SpawnFrequency )
				{
					Log.Trace( $"Spawned {resource.ResourceName}" );
					var resourceEntity = new ModelEntity( resource.Model );
					resourceEntity.Position = new Vector3(
						x * TILE_WIDTH,
						y * TILE_HEIGHT
					);
				}
			}
		}
	}
}
