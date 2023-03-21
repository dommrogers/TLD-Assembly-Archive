using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

[Serializable]
public class InteractionEventEntry
{
	public InteractionEventType m_EventType;

	public InteractionEvent m_Event;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public InteractionEventEntry()
	{
	}
}
