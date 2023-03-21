using Cpp2ILInjected.CallAnalysis;

public struct MapDetailStateData
{
	public bool m_IsUnlocked;

	public bool m_IsDiscovered;

	public bool m_IsSurveyed;

	[CallerCount(Count = 0)]
	public MapDetailStateData(bool isUnlocked, bool isDiscovered, bool isSurveyed)
	{
	}
}
