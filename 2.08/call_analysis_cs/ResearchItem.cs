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

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ResearchItem), Member = "OnResearchComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[CallsUnknownMethods(Count = 2)]
	public void Read(float timeOfDayHours)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[CallerCount(Count = 0)]
	public bool NoBenefitAtCurrentSkillLevel()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "ResearchedBook")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnResearchComplete()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ReadComplete")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GearItem), Member = "IsGearType")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ResearchItem), Member = "GetHoursResearchRemaining")]
	public bool IsResearchComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkAsRead()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnReadHoursIncrease")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetSkillNameLocalized()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetSkillIconName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ResearchItem()
	{
	}
}
