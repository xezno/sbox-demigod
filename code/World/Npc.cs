namespace Demigod;

public class Npc : AnimatedEntity
{
	private CitizenAnimationHelper citizenAnimationHelper;

	[ConVar.Replicated( "dg_npc_debug", Help = "Enable debug overlays for NPC entities" )]
	public static bool DebugNpcs { get; set; } = false;

	public override void Spawn()
	{
		base.Spawn();

		SetModel( "models/citizen/citizen.vmdl" );
		citizenAnimationHelper = new( this );
	}

	public override void Simulate( Client cl )
	{
		base.Simulate( cl );

		DebugOverlay.Text( "NPC", Position, maxDistance: float.MaxValue );
	}
}
