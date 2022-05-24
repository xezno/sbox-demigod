public static class LogExtensions
{
	public static void TraceContext( this Logger log, object obj )
	{
		var prefix = Host.IsClient ? "CL" : "SV";
		log.Trace( $"{prefix}: {obj}" );
	}
}
