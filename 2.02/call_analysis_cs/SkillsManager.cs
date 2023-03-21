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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 27)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 21)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ResearchItem), Member = "NoBenefitAtCurrentSkillLevel")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillIconName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	public Skill GetSkill(SkillType skillType)
	{
		return null;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Skill GetSkillFromIndex(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumSkills()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 3)]
	public string GetTierName(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	public bool AllSkillsAtMaxmiumLevel()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateClothingSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(FireManager), Member = "UpdateSkillAfterFireCreationAttempt")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void IncrementPointsAndNotify(SkillType skillType, int numPoints, PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private GameObject InstantiateSkillPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SkillsManager()
	{
	}
}
