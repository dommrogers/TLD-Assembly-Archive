using Cpp2ILInjected.CallAnalysis;

public class KnowledgeManagerSaveData
{
	public string m_TrustDictSerialized;

	public string m_KnowledgeDictSerialized;

	public string m_NameRefDictSerialized;

	public bool m_SnowSheltersUnlockedInStory;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public KnowledgeManagerSaveData()
	{
	}
}
