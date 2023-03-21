using Cpp2ILInjected.CallAnalysis;

public class InteractionOverrideSaveData
{
	public bool m_Active;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public InteractionOverrideSaveData()
	{
	}
}
