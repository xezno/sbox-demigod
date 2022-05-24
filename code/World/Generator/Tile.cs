namespace Demigod;

public class Tile : ModelEntity
{
	public override void Spawn()
	{
		base.Spawn();

		SetModel( "models/plane.vmdl" );

		Transmit = TransmitType.Always;
	}
}
