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

	private void SetupWorld()
	{
		var sky = new Sky( "materials/skybox/light_test_sky_sunny_basic.vmat" );
		var envLight = new EnvironmentLightEntity();
		envLight.Rotation = Rotation.From( 90, 0, 0 );

		var procGen = new ProceduralWorldGenerator();
		procGen.Generate();
	}
}
