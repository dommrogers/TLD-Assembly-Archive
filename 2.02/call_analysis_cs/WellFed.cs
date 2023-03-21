using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WellFed : MonoBehaviour
{
	public float m_HoursNotStarvingRequired;

	public float m_CarryCapacityBonusKG;

	public float m_MaxConditionBonusPercent;

	public string m_WellFedVO;

	private bool m_Active;

	private float m_ElapsedHoursNotStarving;

	private bool m_StartHasBeenCalled;

	private static WellFedSaveDataProxy m_WellFedSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	[Calls(Type = typeof(WellFed), Member = "CheckForWellFed")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(WellFed), Member = "CheckForWellFed")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_well_fed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	public void WellFedStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WellFed), Member = "UpdateWellFed")]
	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_lose_all")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetCauseString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWellFed()
	{
	}

	[CalledBy(Type = typeof(WellFed), Member = "Update")]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void CheckForWellFed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WellFed()
	{
	}
}
