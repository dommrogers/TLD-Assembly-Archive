using Cpp2ILInjected.CallAnalysis;

public class BodyCarrySaveDataProxy
{
	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BodyCarrySaveDataProxy()
	{
	}
}
