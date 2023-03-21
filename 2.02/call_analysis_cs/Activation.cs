using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class Activation
{
	public float m_StartTime;

	public float m_Duration;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Activation()
	{
	}
}
