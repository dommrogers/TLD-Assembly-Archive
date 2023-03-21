using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	private void MaybeSaveProfile()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void FullyHarvestedDeer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void SetWearingPerfectClothesInAllSlots()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "MaybeTriggerAchievement")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingName")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 4)]
	public void WentToSleep(GearItem bedroll)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void UsedMedicine(GearItem medicineItem)
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void HarvestedPlant(string plantName)
	{
	}

	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
	public void ResearchedBook(string bookName)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(AchievementManager), Member = "CheckInteriors")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
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

	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void MaybeUnlockFaithfulCartographer(string sceneName, bool areAllNamedLocationsUnlocked)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_all_faithful_cartographer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FaithfulCartographerSO), Member = "FindPresetCartographyAchevementSceneSetCount")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsRegionCompleteFaithfulCartographer(string sceneName, ref int numCompleted, ref int total)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_achievement_unlock")]
	[CalledBy(Type = typeof(Action_UnlockAchievement), Member = "OnExecute")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void UnlockAchievement(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeUnlockFaithfulCartographerForAllRegions()
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Unlock")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedAchievement")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(SkillsManager), Member = "AllSkillsAtMaxmiumLevel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographerForAllRegions")]
	[Calls(Type = typeof(AchievementManager), Member = "CompletedAllChallenges")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 27)]
	private void CheckAchievements()
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool CheckInteriors(string sceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static bool CompletedAllChallenges()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public AchievementManager()
	{
	}
}
