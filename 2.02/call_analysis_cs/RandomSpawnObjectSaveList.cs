using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RandomSpawnObjectSaveList
{
	public List<RandomSpawnObjectSaveData> m_SaveDataList;

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public RandomSpawnObjectSaveList()
	{
	}
}
