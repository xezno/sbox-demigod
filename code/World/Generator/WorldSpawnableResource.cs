using System.ComponentModel;

namespace Demigod;

[GameResource( "World Spawnable", "wspwn", "Something that can be procedurally generated, like a rock or a tree.",
	Icon = "nature", IconBgColor = "#97e889", IconFgColor = "#000000" )]
public class WorldSpawnableResource : GameResource
{
	public string ResourceName { get; set; }

	[Category( "Spawning" ), Range( 0, 128 ), Description( "Maximum height where this can be placed (0 - 128). 32 is sea level." )]
	public int SpawnRangeMin { get; set; } = 32;

	[Category( "Spawning" ), Range( 0, 128 ), Description( "Maximum height where this can be placed (0 - 128). 32 is sea level." )]
	public int SpawnRangeMax { get; set; } = 64;

	[Category( "Spawning" ), Range( 0, 1 ), Description( "How frequently should this spawn? 0 (never) to 1 (always)" )]
	public float SpawnFrequency { get; set; } = 0.5f;

	[Category( "Display" ), ResourceType( "vmdl" ), Description( "What model should we use for this spawnable?" )]
	public string Model { get; set; }

	[Category( "Game" )]
	public Resources Resource { get; set; }

	[Category( "Game" )]
	public int ResourceCount { get; set; } = 1;
}
