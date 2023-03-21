using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD;
using TLD.Gameplay;
using TLD.Logging;
using TLD.SaveState;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementManager : MonoBehaviour
{
	public enum ChallengeAchievement
	{
		RescueChallengeComplete,
		HuntedChallengeComplete
	}

	public static readonly LogFilter s_LogFilter;

	private PanelReference<Panel_Map> m_Map;

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

	public readonly Dictionary<string, bool> m_MappedRegions;

	public FaithfulCartographerSO m_FaithfulCartographerSO;

	public SandboxConfig m_Interloper;

	public bool m_KilledBear;

	public bool m_WrappedInFur;

	public bool m_CaughtBigFish;

	public bool m_StunnedRabitFarAway;

	public bool m_ClothingSlotsAllPerfect;

	private readonly bool[] m_ChallengeAchievements;

	private int m_Version;

	private bool m_Initialized;

	private static AchievementSaveData m_AchievementSaveData;

	private bool m_SaveProfileRequested;

	public static bool s_DebugVerbose;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	private void MaybeSaveProfile()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	public void UpdateDaysSurvived(int numDays)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	public void SendStat(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SendStat(GameFloatStatType statistic, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SendStat(GameEventStatType statistic)
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public void NightStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void NightEnded()
	{
	}

	[CallerCount(Count = 0)]
	public void WentInsideDuringNight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void FullyHarvestedDeer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AteFoodItem(FoodItem foodItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
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
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Rest), Member = "MaybeTriggerAchievement")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void WentToSleep(GearItem bedroll)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void UsedMedicine(GearItem medicineItem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
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
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 2)]
	public void ResearchedBook(string bookName)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallsUnknownMethods(Count = 1)]
	public void CraftedItem(string itemName)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 0)]
	public void DefeatTimberwolfPack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void SetLongestBurningCampFire(float hours)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	public void ExploredNewInterior(string interiorName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetChallengeAchievementStatus(ChallengeAchievement type, bool completed)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetNumDaysCalorieStoreAboveZero()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CallsUnknownMethods(Count = 11)]
	public void MaybeUnlockFaithfulCartographer(string sceneName, bool areAllNamedLocationsUnlocked)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_all_faithful_cartographer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(FaithfulCartographerSO), Member = "FindPresetCartographyAchevementSceneSetCount")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool IsRegionCompleteFaithfulCartographer(string sceneName, ref int numCompleted, ref int total)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 31)]
	public static void UnlockAchievement(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUnlockFaithfulCartographerForAllRegions()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(SkillsManager), Member = "AllSkillsAtMaxmiumLevel")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "CompletedAllChallenges")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	private void CheckAchievements()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CalledBy(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private bool CheckInteriors(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 1)]
	private static bool CompletedAllChallenges()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public AchievementManager()
	{
	}
}
