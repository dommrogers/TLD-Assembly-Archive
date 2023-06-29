using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD;

[Serializable]
public class RandomSpawnObjectAchievementGroup
{
	public int m_RandomSpawnObjectDuplicatesPilgrim;

	public int m_RandomSpawnObjectDuplicatesVoyageur;

	public int m_RandomSpawnObjectDuplicatesStalker;

	public int m_RandomSpawnObjectDuplicatesInterloper;

	public List<string> m_GroupAchievementLocIds;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RandomSpawnObjectAchievementGroup()
	{
	}
}
