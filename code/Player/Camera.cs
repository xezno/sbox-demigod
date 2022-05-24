namespace Demigod;

public class Camera : CameraMode
{
	public override void Update()
	{
		ZNear = 1;
		ZFar = 25000;
	}
}
