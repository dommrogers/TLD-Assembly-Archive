using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class CustomSpawnedItemChildSaveData
{
	public string m_LocalGuid;

	public string m_Guid;

	public bool m_Destroyed;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CustomSpawnedItemChildSaveData()
	{
	}
}
