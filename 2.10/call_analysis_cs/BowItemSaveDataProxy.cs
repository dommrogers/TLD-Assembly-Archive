using Cpp2ILInjected.CallAnalysis;

public class BowItemSaveDataProxy
{
	public int m_SelectedArrowIndex;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BowItemSaveDataProxy()
	{
	}
}
