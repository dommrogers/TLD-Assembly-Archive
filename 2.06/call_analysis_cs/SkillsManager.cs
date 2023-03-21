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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
	[Calls(Type = typeof(SkillsManager), Member = "InstantiateSkillPrefab")]
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
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(ResearchItem), Member = "NoBenefitAtCurrentSkillLevel")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetSkillIconName")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public Skill GetSkill(SkillType skillType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 2)]
	public Skill GetSkillFromIndex(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetNumSkills()
	{
		return default(int);
	}

	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Skill), Member = "GetCurrentTierName")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateClothingSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(FireManager), Member = "UpdateSkillAfterFireCreationAttempt")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public void IncrementPointsAndNotify(SkillType skillType, int numPoints, PointAssignmentMode mode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SkillsManager), Member = "Awake")]
	private GameObject InstantiateSkillPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SkillsManager()
	{
	}
}
