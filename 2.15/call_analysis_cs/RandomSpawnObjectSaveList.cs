using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RandomSpawnObjectSaveList
{
	public List<RandomSpawnObjectSaveData> m_SaveDataList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RandomSpawnObjectSaveList()
	{
	}
}
