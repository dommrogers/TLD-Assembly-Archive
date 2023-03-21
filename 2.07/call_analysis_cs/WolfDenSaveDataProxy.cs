using Cpp2ILInjected.CallAnalysis;

public class WolfDenSaveDataProxy
{
	public string m_Guid;

	public bool m_IsDestroyed;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public WolfDenSaveDataProxy()
	{
	}
}
