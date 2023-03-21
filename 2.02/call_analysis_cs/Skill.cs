using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 3)]
	public int GetTierPoints(int index)
	{
		return default(int);
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public string GetCurrentTierName()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetCurrentTierDescription()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 0)]
	public string GetCurrentTierBenefits()
	{
		return null;
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public string GetTierDescription(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public virtual string GetTierBenefits(int index)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetPoints()
	{
		return default(int);
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPoints(int points, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 3)]
	public void SetTier(int tier, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetPointsAsPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetPointsAsNormalizedValue()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 27)]
	public float GetProgressToNextLevelAsNormalizedValue(int addPoints)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public int GetMaxPoints()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 3)]
	public void IncrementPoints(int increase, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallerCount(Count = 126)]
	[CallsUnknownMethods(Count = 5)]
	public int GetCurrentTierNumber()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Skill_ToolRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Rifle), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Revolver), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_IceFishing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Firestarting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_ClothingRepair), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_CarcassHarvesting), Member = ".ctor")]
	[CalledBy(Type = typeof(Skill_Archery), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Skill_Cooking), Member = ".ctor")]
	public Skill()
	{
	}
}
