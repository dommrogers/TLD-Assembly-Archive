using Cpp2ILInjected.CallAnalysis;

public class SteamPipeValveSocketSaveDataProxy
{
	public string m_Guid;

	public bool m_SteamPipeValveActive;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SteamPipeValveSocketSaveDataProxy()
	{
	}
}
