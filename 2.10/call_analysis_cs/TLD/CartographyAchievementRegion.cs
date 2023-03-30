using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD;

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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CartographyAchievementRegion()
	{
	}
}
