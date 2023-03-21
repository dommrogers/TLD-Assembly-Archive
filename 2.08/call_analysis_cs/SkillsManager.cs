using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class SkillsManager : MonoBehaviour
{
	public enum PointAssignmentMode
	{
		AssignOnlyInSandbox,
		AssignInAnyMode
	}

	public LocalizedString[] m_TierNames;

	public GameObject m_Skill_Firestarting_Prefab;

	public GameObject m_Skill_CarcassHarvesting_Prefab;

	public GameObject m_Skill_Cooking_Prefab;

	public GameObject m_Skill_IceFishing_Prefab;

	public GameObject m_Skill_Rifle_Prefab;

	public GameObject m_Skill_Archery_Prefab;

	public GameObject m_Skill_ClothingRepair_Prefab;

	public GameObject m_Skill_Revolver_Prefab;

	public GameObject m_Skill_Gunsmithing_Prefab;

	public Skill_Firestarting m_Skill_Firestarting;

	public Skill_CarcassHarvesting m_Skill_CarcassHarvesting;

	public Skill_Cooking m_Skill_Cooking;

	public Skill_IceFishing m_Skill_IceFishing;

	public Skill_Rifle m_Skill_Rifle;

	public Skill_Archery m_Skill_Archery;

	public Skill_ClothingRepair m_Skill_ClothingRepair;

	public Skill_Revolver m_Skill_Revolver;

	public Skill_Gunsmithing m_Skill_Gunsmithing;

	private List<Skill> m_Skills;

	private static SkillsManagerSaveData m_SkillsManagerSaveData;

	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillIconName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(ResearchItem), Member = "NoBenefitAtCurrentSkillLevel")]
	public Skill GetSkill(SkillType skillType)
	{
		return null;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	public Skill GetSkillFromIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumSkills()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public string GetTierName(int index)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	public bool AllSkillsAtMaxmiumLevel()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateClothingSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(FireManager), Member = "UpdateSkillAfterFireCreationAttempt")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	public void IncrementPointsAndNotify(SkillType skillType, int numPoints, PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	private GameObject InstantiateSkillPrefab(GameObject prefab)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SkillsManager()
	{
	}
}
