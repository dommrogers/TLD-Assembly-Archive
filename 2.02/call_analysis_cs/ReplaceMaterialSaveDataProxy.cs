using Cpp2ILInjected.CallAnalysis;

public class ReplaceMaterialSaveDataProxy
{
	public int m_NewMatIndex;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ReplaceMaterialSaveDataProxy()
	{
	}
}
