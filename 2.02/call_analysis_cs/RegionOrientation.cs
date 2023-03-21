using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RegionOrientation
{
	public string m_RegionName;

	public float m_RotationDegrees;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public RegionOrientation()
	{
	}
}
