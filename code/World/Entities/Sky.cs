namespace Demigod;

public partial class Sky : Entity
{
	[Net] public string Skyname { get; set; }

	public Color TintColor { get; set; } = Color.White;

	public SceneSkyBox.FogType FogType { get; set; } = SceneSkyBox.FogType.Distance;
	public float FogMinStart { get; set; } = -25.0f;
	public float FogMinEnd { get; set; } = -35.0f;
	public float FogMaxStart { get; set; } = 25.0f;
	public float FogMaxEnd { get; set; } = 35.0f;

	public Material SkyMaterial { get; set; }
	public SceneSkyBox SkyObject { get; set; }

	public Sky() : base()
	{
		Transmit = TransmitType.Always;
	}

	public Sky( string skyname ) : this()
	{
		Skyname = skyname;
	}

	public override void ClientSpawn()
	{
		base.ClientSpawn();

		CreateSky();
	}

	private void CreateSky()
	{
		Host.AssertClient();

		if ( string.IsNullOrWhiteSpace( Skyname ) )
			return;

		SkyMaterial = Material.Load( Skyname );
		if ( SkyMaterial == null )
			return;

		SkyObject = new SceneSkyBox( Scene, SkyMaterial )
		{
			Transform = new Transform( Vector3.Zero, LocalRotation ),
			SkyTint = TintColor,
			FogParams = new SceneSkyBox.FogParamInfo
			{
				FogType = FogType,
				FogMinStart = FogMinStart,
				FogMinEnd = FogMinEnd,
				FogMaxStart = FogMaxStart,
				FogMaxEnd = FogMaxEnd,
			}
		};
	}
}
