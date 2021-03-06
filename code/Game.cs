global using Sandbox;
global using Sandbox.UI;
global using Sandbox.UI.Construct;
global using System;
global using System.Linq;

namespace Demigod;

public partial class DemigodGame : Game
{
	public DemigodGame()
	{
		Log.TraceContext( "Demigod Game Started" );
	}

	public override void PostLevelLoaded()
	{
		base.PostLevelLoaded();

		SetupWorld();
	}

	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );

		var player = new Player();
		player.Owner = this;

		cl.Pawn = player;
	}

	private EnvironmentLightEntity environmentLight;

	public override void Simulate( Client cl )
	{
		base.Simulate( cl );

		// This is just here so that I can adjust it easily
		// todo: move it to SetupWorld
		if ( IsServer )
		{
			Map.Scene.AmbientLightColor = new Color( 0.5f );
			environmentLight.Rotation = Rotation.From( 120, 0, 0 );
		}
	}

	private void SetupWorld()
	{
		var sky = new Sky( "materials/skybox/light_test_sky_sunny_basic.vmat" );
		environmentLight = new EnvironmentLightEntity();

		var procGen = new ProceduralWorldGenerator();
		procGen.Generate();
	}
}
