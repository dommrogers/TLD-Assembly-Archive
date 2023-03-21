using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class AchievementSaveData
{
	public int m_Version;

	public int m_NumDaysSurvived;

	public int m_ConsecutiveNightsSurvived;

	public int m_FullyHarvestedDeer;

	public bool m_StartedNightOutside;

	public bool m_WentInsideThisNight;

	public bool m_HasFiredGun;

	public bool m_HasKilledSomething;

	public bool m_LakeRegionAllInteriors;

	public bool m_CoastalRegionAllInteriors;

	public int m_NumDaysLivingOffLand;

	public bool m_UsedRosehipTea;

	public bool m_UsedReishiTea;

	public bool m_UsedOldMansBeardDressing;

	public int m_NumRosehipPlantsHarvested;

	public int m_NumReishiPlantsHarvested;

	public int m_NumOldMansPlantsHarvested;

	public int m_NumCatTailPlantsHarvested;

	public int m_NumDaysCalorieStoreAboveZero;

	public int m_NumArcheryBooksRead;

	public int m_NumCarcassHarvestingBooksRead;

	public int m_NumCookingBooksRead;

	public int m_NumFireStartingBooksRead;

	public int m_NumIceFishingBooksRead;

	public int m_NumMendingBooksRead;

	public int m_NumRifleFirearmAdvancedBooksRead;

	public int m_NumRifleFirearmBooksRead;

	public int m_NumRevolverBooksRead;

	public int m_NumGunsmithingBooksRead;

	public int m_NumImprovisedKnivesCrafted;

	public int m_NumImprovisedHatchetsCrafted;

	public int m_LongestBurningCampFire;

	public bool m_FoundAllCachesEpisodeOne;

	public bool m_FoundAllCachesEpisodeTwo;

	public int m_NumTimberwolfPacksDefeated;

	public Dictionary<string, bool> m_MappedRegions;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AchievementSaveData()
	{
	}
}
