using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Transmitters.UI;

namespace InteractiveObjects;

public class TransmitterRuntimeState
{
	public bool m_IsFixed;

	public bool m_IsOpen;

	public bool m_IsDiscovered;

	public readonly List<RepairableItemSaveState> m_RepairableItems;

	public bool IsActive
	{
		[CalledBy(Type = typeof(TrackableItem), Member = "IsUnlocked")]
		[CalledBy(Type = typeof(FakeTrackableItem), Member = "IsUnlocked")]
		[CalledBy(Type = typeof(TransmitterSiteListItem), Member = "Compare")]
		[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "SortListItems")]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	public bool CanSendSignal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Transmitter), Member = "OnItemRepaired")]
	[CalledBy(Type = typeof(TransmitterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public RepairableItemSaveState GetRepairableStateForGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(TransmitterManager), Member = "Awake")]
	[CalledBy(Type = typeof(TransmitterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TransmitterRuntimeState()
	{
	}
}
