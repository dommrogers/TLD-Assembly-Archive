using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RandomId
{
	public AiMode m_AiMode;

	public int m_NumAnims;

	public float m_MinSecondsDelay;

	public float m_MaxSecondsDelay;

	[CallerCount(Count = 0)]
	public RandomId()
	{
	}
}
