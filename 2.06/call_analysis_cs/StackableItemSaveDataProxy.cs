using Cpp2ILInjected.CallAnalysis;

public class StackableItemSaveDataProxy
{
	public int m_UnitsProxy;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public StackableItemSaveDataProxy()
	{
	}
}
