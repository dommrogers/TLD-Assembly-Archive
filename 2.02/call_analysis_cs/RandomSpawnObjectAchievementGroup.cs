using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RandomSpawnObjectAchievementGroup
{
	public int m_RandomSpawnObjectDuplicatesPilgrim;

	public int m_RandomSpawnObjectDuplicatesVoyageur;

	public int m_RandomSpawnObjectDuplicatesStalker;

	public int m_RandomSpawnObjectDuplicatesInterloper;

	public List<string> m_GroupAchievementLocIds;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RandomSpawnObjectAchievementGroup()
	{
	}
}
