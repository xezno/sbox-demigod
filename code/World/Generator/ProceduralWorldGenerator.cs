namespace Demigod;

public class ProceduralWorldGenerator
{
	private const int TILES_X = 32;
	private const int TILES_Y = 32;

	private const float TILE_WIDTH = 64f;
	private const float TILE_HEIGHT = 64f;

	public void Generate()
	{
		int halfTilesX = TILES_X / 2;
		int halfTilesY = TILES_Y / 2;

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
			}
		}
	}
}
