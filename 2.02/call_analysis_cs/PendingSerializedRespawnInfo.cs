using Cpp2ILInjected.CallAnalysis;

public class PendingSerializedRespawnInfo
{
	public SpawnDataProxy m_SaveData;

	public int m_TrySpawnCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PendingSerializedRespawnInfo()
	{
	}
}
