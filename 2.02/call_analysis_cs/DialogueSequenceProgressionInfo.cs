using Cpp2ILInjected.CallAnalysis;

public class DialogueSequenceProgressionInfo
{
	public string m_UniqueId;

	public int m_CurrentProgressionIndex;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DialogueSequenceProgressionInfo()
	{
	}
}
