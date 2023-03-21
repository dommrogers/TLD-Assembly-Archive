using Cpp2ILInjected.CallAnalysis;

public class SmashableItemSaveDataProxy
{
	public bool m_HasBeenSmashed;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SmashableItemSaveDataProxy()
	{
	}
}
