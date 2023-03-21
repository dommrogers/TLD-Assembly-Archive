using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RandomSpawnObjectSaveList
{
	public List<RandomSpawnObjectSaveData> m_SaveDataList;

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RandomSpawnObjectSaveList()
	{
	}
}
