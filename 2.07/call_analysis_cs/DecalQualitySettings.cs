using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class DecalQualitySettings
{
	public float m_FadeDistance;

	public float m_VisibleDistance;

	public float m_FadeScreenSize;

	public float m_VisibleScreenSize;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DecalQualitySettings()
	{
	}
}
