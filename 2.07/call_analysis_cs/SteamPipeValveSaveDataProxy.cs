using Cpp2ILInjected.CallAnalysis;

public class SteamPipeValveSaveDataProxy
{
	public string m_Guid;

	public bool m_IsFrozen;

	public bool m_IsOpen;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SteamPipeValveSaveDataProxy()
	{
	}
}
