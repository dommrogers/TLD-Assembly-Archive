using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementManager : MonoBehaviour
{
	public enum ChallengeAchievement
	{
		RescueChallengeComplete,
		HuntedChallengeComplete
	}

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

	public FaithfulCartographerSO m_FaithfulCartographerSO;

	public bool m_KilledBear;

	public bool m_WrappedInFur;

	public bool m_CaughtBigFish;

	public bool m_StunnedRabitFarAway;

	public bool m_ClothingSlotsAllPerfect;

	private Dictionary<ChallengeAchievement, bool> m_ChallengeAchievements;

	private int m_Version;

	private bool m_Initialized;

	private static AchievementSaveData m_AchievementSaveData;

	private Dictionary<string, int> m_NumTopLevelIconsPerRegion;

	private Dictionary<string, int> m_NumLocationTriggersPerRegion;

	private bool m_SaveProfileRequested;

	public static bool s_DebugVerbose;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(RegionManager), Member = "GetSceneFilename")]
	[CallsUnknownMethods(Count = 14)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeSaveProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateCacheAchievementInProfile")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 6)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAchievements()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	public void UpdateDaysSurvived(int numDays)
	{
	}

	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SendStat(GameIntStatType statistic, int amount)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SendStat(GameFloatStatType statistic, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SendStat(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public void NightStarted()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void NightEnded()
	{
	}

	[CallerCount(Count = 0)]
	public void WentInsideDuringNight()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void FullyHarvestedDeer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	public void AteFoodItem(FoodItem foodItem)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CaughtFish(GearItem fishItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void MaybeUnlockStoneAgeSniper(float distance)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void SetWearingPerfectClothesInAllSlots()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Rest), Member = "MaybeTriggerAchievement")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void WentToSleep(GearItem bedroll)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void UsedMedicine(GearItem medicineItem)
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Harvestable), Member = "CompletedHarvest")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public void HarvestedPlant(string plantName)
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public void ResearchedBook(string bookName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddCraftedItemToInventory")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public void CraftedItem(string itemName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void DefeatTimberwolfPack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void SetLongestBurningCampFire(float hours)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void ExploredNewInterior(string interiorName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetChallengeAchievementStatus(ChallengeAchievement type, bool completed)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetNumDaysCalorieStoreAboveZero()
	{
	}

	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	public void MaybeUnlockFaithfulCartographer(string sceneName, bool areAllNamedLocationsUnlocked)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_all_faithful_cartographer")]
	[CallsUnknownMethods(Count = 7)]
	public bool IsRegionCompleteFaithfulCartographer(string sceneName, ref int numCompleted, ref int total)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_FoundAllHiddenCaches), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void UpdateCacheAchievementInProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_UnlockAchievement), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_achievement_unlock")]
	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasMarkedAchievementUnlocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkAchievementUnlocked")]
	public static void UnlockAchievement(Achievement achievement)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void MaybeUnlockFaithfulCartographerForAllRegions()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	private void CheckAchievements()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CalledBy(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private bool CheckInteriors(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private static bool CompletedAllChallenges()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 34)]
	[CallsUnknownMethods(Count = 24)]
	public AchievementManager()
	{
	}
}
