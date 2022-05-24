namespace Demigod;

public class Hand : AnimatedEntity
{
	protected virtual string HandModel { get; }
	protected virtual Input.VrHand InputHand { get; }

	public override void Spawn()
	{
		base.Spawn();

		SetModel( HandModel );
	}

	public override void Simulate( Client cl )
	{
		base.Simulate( cl );

		Transform = InputHand.Transform;
	}
}
