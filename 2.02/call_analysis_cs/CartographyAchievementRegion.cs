using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class CartographyAchievementRegion
{
	public string m_RegionName;

	public int m_RandomSpawnObjectDuplicatesPilgrim;

	public int m_RandomSpawnObjectDuplicatesVoyageur;

	public int m_RandomSpawnObjectDuplicatesStalker;

	public int m_RandomSpawnObjectDuplicatesInterloper;

	public List<CartographyAchievement> m_TopLevelIcons;

	public List<CartographyAchievement> m_LocationTriggers;

	public List<RandomSpawnObjectAchievementGroup> m_RandomSpawnObjectAchievementGroups;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CartographyAchievementRegion()
	{
	}
}
