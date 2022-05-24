namespace Demigod;

public partial class Player : AnimatedEntity
{
	[Net, Predicted] public Hand LeftHand { get; set; }
	[Net, Predicted] public Hand RightHand { get; set; }

	public CameraMode CameraMode
	{
		get => Components.Get<CameraMode>();
		set => Components.Add( value );
	}

	public override void Spawn()
	{
		base.Spawn();

		SetModel( "models/citizen/citizen.vmdl" );

		// Disable everything but the player's head
		SetBodyGroup( "Chest", 1 );
		SetBodyGroup( "Legs", 1 );
		SetBodyGroup( "Hands", 1 );
		SetBodyGroup( "Feet", 1 );

		// Set up player hands
		LeftHand = new LeftHand() { Owner = this };
		RightHand = new RightHand() { Owner = this };

		// Set up camera
		CameraMode = new Camera();
	}
}
