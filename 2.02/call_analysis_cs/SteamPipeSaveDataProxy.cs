using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveDataProxy
{
	public string m_Guid;

	public bool m_IsFrozen;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SteamPipeSaveDataProxy()
	{
	}
}
