using System;
using Cpp2ILInjected.CallAnalysis;

namespace SWS;

[Serializable]
public class RangeValue
{
	public float min;

	public float max;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RangeValue()
	{
	}
}
