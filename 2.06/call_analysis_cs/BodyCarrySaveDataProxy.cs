using Cpp2ILInjected.CallAnalysis;

public class BodyCarrySaveDataProxy
{
	public string m_Guid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BodyCarrySaveDataProxy()
	{
	}
}
