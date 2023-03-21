using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Burns : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_MaxHitPointsReduction;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_ClothingDamagePerSecondMin;

	public float m_ClothingDamagePerSecondMax;

	public GameObject m_PainKillersPrefab;

	public GameObject m_BandagePrefab;

	public string m_BurnInitialDamageVO;

	public string m_BurnSecondaryDamageVO;

	public string m_BurnDamageReminderVO;

	public int[] m_BurnReminderTimesInSeconds;

	public float m_InitialDamageVOCooldown;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_Active;

	private float m_ElapsedHours;

	private float m_DurationHours;

	private bool m_PainKillersTaken;

	private bool m_BandageApplied;

	private float m_ClothingDamagePerSecond;

	private bool m_StartHasBeenCalled;

	private int m_NumBurnRemindersPlayed;

	private float m_SecondsUntilNextBurnReminder;

	private string m_CauseLocID;

	private float m_NextBurnInitialVOTimer;

	private static BurnsSaveDataProxy m_BurnsSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_nofx")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void BurnsStart(string causeLocID, bool displayIcon, bool nofx = false, AfflictionOptions options = AfflictionOptions.None)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateBurns")]
	[CalledBy(Type = typeof(Burns), Member = "Update")]
	[CalledBy(Type = typeof(Burns), Member = "TakePainKillers")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Burns), Member = "ApplyBandage")]
	public void BurnsEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasBurns()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	public bool RequiresPainkillers()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	public void TakePainKillers()
	{
	}

	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[CallerCount(Count = 0)]
	public void ApplyBandage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[CallerCount(Count = 0)]
	public void ApplyClothingDamage(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	public string GetCauseLocID()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBurns()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybePlayBurnReminder()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Burns()
	{
	}
}
