using Cpp2ILInjected.CallAnalysis;

public class EpisodeTransferData
{
	public string m_StoryGlobalSerialized;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public EpisodeTransferData()
	{
	}
}
