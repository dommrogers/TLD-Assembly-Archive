using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RampRange
{
	public float m_MinGoalSpeed;

	public float m_MaxGoalSpeed;

	public float m_Acceleration;

	[CallerCount(Count = 0)]
	public RampRange()
	{
	}
}
