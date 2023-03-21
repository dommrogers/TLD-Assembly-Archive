using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ToxicFogRegionTunables
{
	public GameRegion m_Region;

	public float m_TimeToFillUpToMaximumMinutes;

	[CallerCount(Count = 0)]
	public ToxicFogRegionTunables()
	{
	}
}
