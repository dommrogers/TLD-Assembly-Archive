using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ToxicFogIndicatorTunables
{
	public float m_Level1;

	public float m_Level2;

	public float m_Level3;

	[CallerCount(Count = 0)]
	public ToxicFogIndicatorTunables()
	{
	}
}
