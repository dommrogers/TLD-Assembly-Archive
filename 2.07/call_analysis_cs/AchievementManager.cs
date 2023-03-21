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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallerCount(Count = 0)]
	private void MaybeSaveProfile()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 28)]
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
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SendStat(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	public void FullyHarvestedDeer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 0)]
	public void SetWearingPerfectClothesInAllSlots()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Rest), Member = "MaybeTriggerAchievement")]
	[CallsUnknownMethods(Count = 4)]
	public void WentToSleep(GearItem bedroll)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void UsedMedicine(GearItem medicineItem)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	public void HarvestedPlant(string plantName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public void ResearchedBook(string bookName)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void CraftedItem(string itemName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void DefeatTimberwolfPack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void SetLongestBurningCampFire(float hours)
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	public void ExploredNewInterior(string interiorName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetChallengeAchievementStatus(ChallengeAchievement type, bool completed)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetNumDaysCalorieStoreAboveZero()
	{
	}

	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void MaybeUnlockFaithfulCartographer(string sceneName, bool areAllNamedLocationsUnlocked)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_all_faithful_cartographer")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(FaithfulCartographerSO), Member = "FindPresetCartographyAchevementSceneSetCount")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	public bool IsRegionCompleteFaithfulCartographer(string sceneName, ref int numCompleted, ref int total)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static void UnlockAchievement(Achievement achievement)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	private void MaybeUnlockFaithfulCartographerForAllRegions()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(SkillsManager), Member = "AllSkillsAtMaxmiumLevel")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "CompletedAllChallenges")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
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
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private bool CheckInteriors(string sceneName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static bool CompletedAllChallenges()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	public AchievementManager()
	{
	}
}
