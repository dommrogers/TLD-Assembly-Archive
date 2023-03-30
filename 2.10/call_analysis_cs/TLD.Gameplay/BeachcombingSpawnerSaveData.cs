using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class BeachcombingSpawnerSaveData
{
	public string m_Guid;

	public int m_LastActiveBlizzardID;

	public List<BeachcombingBigItemSaveData> m_BigItems;

	public int m_BigItemsToSpawn;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BeachcombingSpawnerSaveData()
	{
	}
}
