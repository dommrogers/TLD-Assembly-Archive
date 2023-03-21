using Cpp2ILInjected.CallAnalysis;

public class ActiveSwitchSaveData
{
	public int m_ActiveStateIndex;

	public string m_Guid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ActiveSwitchSaveData()
	{
	}
}
