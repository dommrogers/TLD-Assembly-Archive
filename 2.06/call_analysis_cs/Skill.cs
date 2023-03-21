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
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	public string GetCurrentTierName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	public string GetCurrentTierDescription()
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 0)]
	public string GetCurrentTierBenefits()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Skill), Member = "SetTier")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 7)]
	public void SetPoints(int points, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 2)]
	public void SetTier(int tier, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetPointsAsPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetPointsAsNormalizedValue()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgressToNextLevelAsNormalizedValue(int addPoints)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 132)]
	[CallsUnknownMethods(Count = 2)]
	public int GetCurrentTierNumber()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Skill_Firestarting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_ToolRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Rifle), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Revolver), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_IceFishing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Cooking), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_ClothingRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Archery), Member = ".ctor")]
	[CallerCount(Count = 10)]
	public Skill()
	{
	}
}
