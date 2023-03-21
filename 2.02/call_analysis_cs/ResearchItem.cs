using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ResearchItem : MonoBehaviour
{
	public SkillType m_SkillType;

	public int m_TimeRequirementHours;

	public int m_SkillPoints;

	public int m_NoBenefitAtSkillLevel;

	public string m_ReadAudio;

	private float m_ElapsedHours;

	private static ResearchItemSaveData m_ResearchItemSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(ResearchItem), Member = "UpdateItemType")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Read(float timeOfDayHours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public bool NoBenefitAtCurrentSkillLevel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ResearchItem), Member = "UpdateItemType")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	public void OnResearchComplete()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public bool IsResearchComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkAsRead()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public int GetHoursResearchRemaining()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetElapsedHours()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CallsUnknownMethods(Count = 4)]
	public string GetSkillNameLocalized()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	public string GetSkillIconName()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateItemType(GearTypeEnum newType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ResearchItem()
	{
	}
}
