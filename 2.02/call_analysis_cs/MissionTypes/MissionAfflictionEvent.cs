using Cpp2ILInjected.CallAnalysis;

namespace MissionTypes;

public class MissionAfflictionEvent
{
	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public AfflictionType m_AfflictionType;

	public AfflictionEventType m_EventType;

	public const string AFFLICTION_EVENT_NAME = "AfflictionEvent";

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MissionAfflictionEvent(MissionObjectIdentifier moi, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}
}
