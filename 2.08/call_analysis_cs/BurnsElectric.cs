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
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void BurnsElectricStart(bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_cure")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateBurnsElectric")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "TakePainKillers")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyBandage")]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public bool RequiresPainkillers()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	public void TakePainKillers()
	{
	}

	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBurnsElectric()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void MaybePlayBurnReminder()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BurnsElectric()
	{
	}
}
