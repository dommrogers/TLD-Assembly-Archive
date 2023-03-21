using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class WellFed : MonoBehaviour
{
	public float m_HoursNotStarvingRequired;

	public float m_CarryCapacityBonusKG;

	public float m_MaxConditionBonusPercent;

	public string m_WellFedVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_Active;

	private float m_ElapsedHoursNotStarving;

	private bool m_StartHasBeenCalled;

	private static WellFedSaveDataProxy m_WellFedSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	public void Update()
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

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_well_fed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(WellFed), Member = "CheckForWellFed")]
	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	public void WellFedStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(WellFed), Member = "UpdateWellFed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_lose_all")]
	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	public void WellFedEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasWellFed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetCauseString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	private void UpdateWellFed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForWellFed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WellFed()
	{
	}
}
