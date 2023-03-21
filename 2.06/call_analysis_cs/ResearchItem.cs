using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	public void Read(float timeOfDayHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 1)]
	public bool NoBenefitAtCurrentSkillLevel()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public void OnResearchComplete()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(GearItem), Member = "IsGearType")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 11)]
	public bool IsResearchComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkAsRead()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	public int GetHoursResearchRemaining()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetElapsedHours()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallsUnknownMethods(Count = 1)]
	public string GetSkillNameLocalized()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	public string GetSkillIconName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ResearchItem()
	{
	}
}
