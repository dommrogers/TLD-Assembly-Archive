using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveData
{
	public string m_Guid;

	public string m_SerializedData;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SteamPipeSaveData()
	{
	}
}
