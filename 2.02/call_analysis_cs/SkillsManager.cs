using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[CalledBy(Type = typeof(ResearchItem), Member = "NoBenefitAtCurrentSkillLevel")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillIconName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public Skill GetSkill(SkillType skillType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 2)]
	public Skill GetSkillFromIndex(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumSkills()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	public string GetTierName(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	public bool AllSkillsAtMaxmiumLevel()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateClothingSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(FireManager), Member = "UpdateSkillAfterFireCreationAttempt")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	public void IncrementPointsAndNotify(SkillType skillType, int numPoints, PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject InstantiateSkillPrefab(GameObject prefab)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public SkillsManager()
	{
	}
}
