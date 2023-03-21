using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MinMax
{
	public float m_Min;

	public float m_Max;

	[CallerCount(Count = 0)]
	public MinMax()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MinMax(float min, float max)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetMin()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetMax()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetMiddle()
	{
		return default(float);
	}
}
