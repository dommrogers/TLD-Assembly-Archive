using Cpp2ILInjected.CallAnalysis;

public class ActiveSwitchSaveData
{
	public int m_ActiveStateIndex;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ActiveSwitchSaveData()
	{
	}
}
