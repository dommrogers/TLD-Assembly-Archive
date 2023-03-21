using Cpp2ILInjected.CallAnalysis;

public class StackableItemSaveDataProxy
{
	public int m_UnitsProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public StackableItemSaveDataProxy()
	{
	}
}
