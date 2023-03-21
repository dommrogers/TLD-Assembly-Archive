using Cpp2ILInjected.CallAnalysis;

public class EpisodeTransferData
{
	public string m_StoryGlobalSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EpisodeTransferData()
	{
	}
}
