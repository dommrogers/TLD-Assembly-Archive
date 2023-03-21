using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveData
{
	public string m_Guid;

	public string m_SerializedData;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SteamPipeSaveData()
	{
	}
}
