using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LacerationEvent : MinorBruisingEvent
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LacerationEvent()
	{
	}
}
