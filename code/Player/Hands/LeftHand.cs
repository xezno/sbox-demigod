namespace Demigod;

internal class LeftHand : Hand
{
	protected override string HandModel => "models/hands/alyx_hand_left.vmdl";
	protected override Input.VrHand InputHand => Input.VR.LeftHand;
}
