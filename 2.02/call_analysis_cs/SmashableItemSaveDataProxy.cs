using Cpp2ILInjected.CallAnalysis;

public class SmashableItemSaveDataProxy
{
	public bool m_HasBeenSmashed;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SmashableItemSaveDataProxy()
	{
	}
}
