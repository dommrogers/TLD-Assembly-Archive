using Cpp2ILInjected.CallAnalysis;

public class CollectionManagerSaveData
{
	public string m_UnlockedCairnsDictSerialized;

	public string m_UnlockedAuroraSetSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CollectionManagerSaveData()
	{
	}
}
