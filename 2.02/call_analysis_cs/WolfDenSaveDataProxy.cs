using Cpp2ILInjected.CallAnalysis;

public class WolfDenSaveDataProxy
{
	public string m_Guid;

	public bool m_IsDestroyed;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public WolfDenSaveDataProxy()
	{
	}
}
