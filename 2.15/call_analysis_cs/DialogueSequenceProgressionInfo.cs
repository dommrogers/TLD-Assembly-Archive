using Cpp2ILInjected.CallAnalysis;

public class DialogueSequenceProgressionInfo
{
	public string m_UniqueId;

	public int m_CurrentProgressionIndex;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DialogueSequenceProgressionInfo()
	{
	}
}
