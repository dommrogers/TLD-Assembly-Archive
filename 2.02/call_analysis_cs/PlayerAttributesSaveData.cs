using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class PlayerAttributesSaveData
{
	public float m_Strength;

	public float m_MaxStrength;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayerAttributesSaveData()
	{
	}
}
