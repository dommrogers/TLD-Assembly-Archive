using Cpp2ILInjected.CallAnalysis;

namespace InteractiveObjects;

public class TrackableItemSaveData
{
	public bool m_IsUncovered;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public TrackableItemSaveData()
	{
	}
}
