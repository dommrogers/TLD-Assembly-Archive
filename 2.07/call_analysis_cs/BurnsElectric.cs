using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class BurnsElectric : MonoBehaviour
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

	public string m_IconSpriteName;

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

	private float m_NextBurnInitialVOTimer;

	private static BurnsElectricSaveDataProxy m_BurnsElectricSaveDataProxy;

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

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
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

	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	public void BurnsElectricStart(bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyBandage")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateBurnsElectric")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "TakePainKillers")]
	public void BurnsElectricEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasBurnsElectric()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public bool RequiresPainkillers()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallerCount(Count = 0)]
	public void TakePainKillers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	public void ApplyBandage()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyClothingDamage(float realtimeSeconds)
	{
	}

	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBurnsElectric()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybePlayBurnReminder()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BurnsElectric()
	{
	}
}
