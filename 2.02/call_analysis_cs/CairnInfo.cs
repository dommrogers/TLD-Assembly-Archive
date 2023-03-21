using Cpp2ILInjected.CallAnalysis;

public class CairnInfo
{
	public string m_BackerLookupNum;

	public int m_JournalEntryNumber;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CairnInfo()
	{
	}
}
