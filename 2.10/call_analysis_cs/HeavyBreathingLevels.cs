using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public struct HeavyBreathingLevels
{
	public float m_Light;

	public float m_Medium;

	public float m_Heavy;

	public float Item
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}
}
