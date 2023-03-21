using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveDataProxy
{
	public string m_Guid;

	public bool m_IsFrozen;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SteamPipeSaveDataProxy()
	{
	}
}
