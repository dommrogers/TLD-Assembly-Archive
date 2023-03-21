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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(WellFed), Member = "CheckForWellFed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_well_fed")]
	[CallsUnknownMethods(Count = 3)]
	public void WellFedStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(WellFed), Member = "UpdateWellFed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_lose_all")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	public WellFed()
	{
	}
}
