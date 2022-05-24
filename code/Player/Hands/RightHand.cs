namespace Demigod;

internal class RightHand : Hand
{
	protected override string HandModel => "models/hands/alyx_hand_right.vmdl";
	protected override Input.VrHand InputHand => Input.VR.RightHand;
}
