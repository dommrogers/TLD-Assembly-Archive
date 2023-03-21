using Cpp2ILInjected.CallAnalysis;

public class EpisodeTransferData
{
	public string m_StoryGlobalSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EpisodeTransferData()
	{
	}
}
