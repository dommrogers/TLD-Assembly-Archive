using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class SnowImprintQualitySettings
{
	public bool m_Show;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SnowImprintQualitySettings()
	{
	}
}
