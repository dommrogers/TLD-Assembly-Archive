using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD;

[Serializable]
public class SpawnAnimalTableEntry
{
	public AssetReferenceAnimalPrefab m_AnimalPrefab;

	public AssetReferenceAnimalPrefab m_AuroraAnimalPrefab;

	public float m_Odds;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SpawnAnimalTableEntry()
	{
	}
}
