namespace UnityPlugin;

public enum MultiplayerMeasurementFailure
{
	Unknown,
	None,
	Timeout,
	Latency,
	BandwidthUp,
	BandwidthDown,
	Group,
	Network,
	Episode
}
