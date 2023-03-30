using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MajorBruisingEvent : MinorBruisingEvent
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MajorBruisingEvent()
	{
	}
}
