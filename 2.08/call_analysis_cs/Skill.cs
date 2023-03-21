using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Skill : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public SkillType m_SkillType;

	public int[] m_TierPoints;

	public LocalizedString[] m_TierLocalizedBenefits;

	public LocalizedString[] m_TierLocalizedDescriptions;

	public string m_SkillImage;

	public string m_SkillIcon;

	public string m_SkillIconBackground;

	private int m_CurrentPoints;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 2)]
	public int GetTierPoints(int index)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	public string GetCurrentTierName()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public string GetCurrentTierDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public string GetCurrentTierBenefits()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	public string GetTierDescription(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetPoints()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(Skill), Member = "SetTier")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	public void SetPoints(int points, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	public void SetTier(int tier, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetPointsAsPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetPointsAsNormalizedValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public float GetProgressToNextLevelAsNormalizedValue(int addPoints)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetMaxPoints()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 2)]
	public void IncrementPoints(int increase, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Skill), Member = "GetProgressToNextLevelAsNormalizedValue")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	public int GetCurrentTierNumber()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Skill_ToolRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Rifle), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_IceFishing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Firestarting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Revolver), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_ClothingRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Archery), Member = ".ctor")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Skill_Cooking), Member = ".ctor")]
	public Skill()
	{
	}
}
